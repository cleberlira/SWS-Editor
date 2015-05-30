Imports System.Web.Services.Description
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports Binding = System.Web.Services.Description.Binding
Imports Message = System.Web.Services.Description.Message

Namespace WSDLParser

    Public Class WSDLParser
        Public ServiceNode As TreeNode
        Private _schemas As XmlSchemas
        Private _services As New ServiceDescriptionCollection()

        Public Sub New(service As ServiceDescription)
            _services.Add(service)
            _schemas = service.Types.Schemas

            If service.Name = String.Empty Then
                service.Name = service.RetrievalUrl
            End If
            If service.Name = String.Empty Then
                service.Name = service.TargetNamespace
            End If

            ServiceNode = New TreeNode(service.Name)
            ServiceNode.Tag = service.Documentation
            ServiceNode.ImageIndex = 15
            ServiceNode.SelectedImageIndex = 15

            Parse()

            ServiceNode.Expand()
        End Sub

        Private Function GetProtocol(binding As Binding) As String
            If binding.Extensions.Find(GetType(SoapBinding)) IsNot Nothing Then
                Return "Soap"
            End If
            Dim hb As HttpBinding = DirectCast(binding.Extensions.Find(GetType(HttpBinding)), HttpBinding)
            If hb Is Nothing Then
                Return ""
            End If
            If hb.Verb = "POST" Then
                Return "HttpPost"
            End If
            If hb.Verb = "GET" Then
                Return "HttpGet"
            End If
            Return ""
        End Function




        Private Sub GetOperationFormat(obin As OperationBinding, oper As Operation, ByRef style As SoapBindingStyle, ByRef inputUse As SoapBindingUse, ByRef outputUse As SoapBindingUse, ByRef requestMessage As String, _
            ByRef responseMessage As String, ByRef requestNode As TreeNode, ByRef responseNode As TreeNode)
            style = SoapBindingStyle.Document
            outputUse = SoapBindingUse.Literal
            inputUse = SoapBindingUse.Literal
            requestMessage = String.Empty
            responseMessage = String.Empty
            requestNode = Nothing
            responseNode = Nothing
            Dim pStyle As SoapBindingStyle
            Dim pInputUse As SoapBindingUse, pOutputUse As SoapBindingUse

            GetOperationFormat(obin, pStyle, pInputUse, pOutputUse)
            If oper.Messages.Input IsNot Nothing Then
                requestNode = MessageToTreeNode(oper.Messages.Input, pInputUse)
            End If
            If oper.Messages.Output IsNot Nothing Then
                responseNode = MessageToTreeNode(oper.Messages.Output, pOutputUse)
            End If

            style = pStyle
            outputUse = pOutputUse
            inputUse = pInputUse
        End Sub


        Private Sub GetOperationFormat(obin As OperationBinding, ByRef style As SoapBindingStyle, ByRef inputUse As SoapBindingUse, ByRef outputUse As SoapBindingUse)
            style = SoapBindingStyle.Document
            inputUse = SoapBindingUse.Literal
            outputUse = SoapBindingUse.Literal
            If obin.Extensions IsNot Nothing Then
                Dim sob As SoapOperationBinding = TryCast(obin.Extensions.Find(GetType(SoapOperationBinding)), SoapOperationBinding)
                If sob IsNot Nothing Then
                    style = sob.Style
                    If obin.Input IsNot Nothing Then
                        Dim sbb0 As SoapBodyBinding = TryCast(obin.Input.Extensions.Find(GetType(SoapBodyBinding)), SoapBodyBinding)
                        If sbb0 IsNot Nothing Then
                            inputUse = sbb0.Use
                        End If
                    End If

                    If obin.Output IsNot Nothing Then
                        Dim sbb1 As SoapBodyBinding = TryCast(obin.Output.Extensions.Find(GetType(SoapBodyBinding)), SoapBodyBinding)
                        If sbb1 IsNot Nothing Then
                            outputUse = sbb1.Use
                        End If
                    End If
                End If
            End If
        End Sub


        Private Function MessageToTreeNode(omsg As OperationMessage, use As SoapBindingUse) As TreeNode
            'Dim msg As Message = _services.GetMessage(omsg.Message)

            Dim node As New TreeNode()
            'Dim ngen As New SchemaParser(_schemas)

            'ngen.BindingUse = use

            'For Each part As MessagePart In msg.Parts
            '    If part.Element = XmlQualifiedName.Empty Then
            '        Dim partNode As TreeNode = ngen.Translate(part.Type)
            '        partNode.ImageIndex = 5
            '        partNode.SelectedImageIndex = 5

            '        partNode.Text = part.Name
            '        node.Nodes.Add(partNode)
            '    Else
            '        Dim partNode As TreeNode = ngen.Translate(part.Element)
            '        partNode.ImageIndex = 5
            '        partNode.SelectedImageIndex = 5

            '        partNode.Text = part.Name
            '        node.Nodes.Add(partNode)

            '    End If
            'Next

            Return node

        End Function



        Public Function TranslateOperation(port As Port, obin As OperationBinding, oper As Operation, protocol As String) As TreeNode
            Dim tnOperation As New TreeNode(oper.Name, 13, 13)
            Dim style As New SoapBindingStyle()
            Dim inputUse As New SoapBindingUse()
            Dim outputUse As New SoapBindingUse()

            Dim requestmsg As String = String.Empty
            Dim responsemsg As String = String.Empty
            Dim tnInput As New TreeNode()
            Dim tnOutput As New TreeNode()
            Dim tnFault As New TreeNode("Faults")

            GetOperationFormat(obin, oper, style, inputUse, outputUse, requestmsg, _
                responsemsg, tnInput, tnOutput)

            Dim operDesc As String = String.Empty
            operDesc += oper.Documentation + vbLf
            operDesc += "Style: " + style.ToString() + vbLf

            tnOperation.Tag = operDesc


            Dim messages As MessageCollection = _services(0).Messages
            If oper.Messages.Input IsNot Nothing Then
                Dim messageIn As Message = messages(oper.Messages.Input.Message.Name)
                If messageIn IsNot Nothing Then

                    If tnInput Is Nothing Then
                        tnInput = New TreeNode()
                    End If
                    tnInput.Tag = requestmsg
                    tnInput.ImageIndex = 13
                    tnInput.SelectedImageIndex = 13

                    If oper.Messages.Input.Name IsNot Nothing AndAlso oper.Messages.Input.Name <> String.Empty Then
                        tnInput.Text = "Input: " + oper.Messages.Input.Name
                    Else
                        tnInput.Text = "Input: " + oper.Messages.Input.Message.Name
                    End If


                    If tnInput IsNot Nothing Then
                        tnOperation.Nodes.Add(tnInput)
                    End If
                End If


            End If



            If oper.Messages.Output IsNot Nothing Then
                Dim messageOut As Message = messages(oper.Messages.Output.Message.Name)
                If messageOut IsNot Nothing Then

                    If tnOutput Is Nothing Then
                        tnOutput = New TreeNode()
                    End If
                    tnOutput.Tag = responsemsg
                    tnOutput.ImageIndex = 13
                    tnOutput.SelectedImageIndex = 13

                    If oper.Messages.Output.Name IsNot Nothing AndAlso oper.Messages.Output.Name <> String.Empty Then
                        tnOutput.Text = "Output: " + oper.Messages.Output.Name
                    Else
                        tnOutput.Text = "Output: " + oper.Messages.Output.Message.Name
                    End If

                    If tnOutput IsNot Nothing Then
                        tnOperation.Nodes.Add(tnOutput)
                    End If
                End If



            End If



            For Each faultOp As OperationFault In oper.Faults
                Dim messageFault As Message = messages(faultOp.Message.Name)
                If messageFault IsNot Nothing Then

                    Dim treeNode As New TreeNode()

                    tnFault.ImageIndex = 14
                    tnFault.SelectedImageIndex = 14
                    If treeNode IsNot Nothing Then
                        tnFault.Nodes.Add(treeNode)
                    End If
                End If



            Next



            If tnFault.Nodes.Count > 0 Then
                tnOperation.Nodes.Add(tnFault)
            End If

            Return tnOperation

        End Function

        Public Sub Parse()
            For Each service As Service In _services(0).Services
                Dim tnService As New TreeNode(service.Name)
                tnService.ImageIndex = 1
                tnService.SelectedImageIndex = 1

                For Each port As Port In service.Ports
                    Dim bindName As XmlQualifiedName = port.Binding
                    Dim bind As Binding = _services.GetBinding(bindName)
                    Dim portType As PortType = _services.GetPortType(bind.Type)

                    Dim tnPort As New TreeNode(port.Name)
                    tnPort.ImageIndex = 6
                    tnPort.SelectedImageIndex = 6

                    Dim protocol As String = GetProtocol(bind)
                    Dim portDesc As String = (Convert.ToString("Protocol: ") & protocol) + vbLf

                    Select Case protocol
                        Case "Soap"
                            If True Then
                                Dim ad As SoapAddressBinding = DirectCast(port.Extensions.Find(GetType(SoapAddressBinding)), SoapAddressBinding)
                                portDesc += "Location: " + ad.Location + vbLf
                                Exit Select
                            End If
                        Case "HttpGet"
                            If True Then
                                Dim ad As HttpAddressBinding = DirectCast(port.Extensions.Find(GetType(HttpAddressBinding)), HttpAddressBinding)
                                portDesc += "Location: " + ad.Location + vbLf
                                Exit Select
                            End If
                        Case "HttpPost"
                            If True Then
                                Dim ad As HttpAddressBinding = DirectCast(port.Extensions.Find(GetType(HttpAddressBinding)), HttpAddressBinding)
                                portDesc += "Location: " + ad.Location + vbLf
                                Exit Select
                            End If
                    End Select

                    tnPort.Tag = portDesc
                    For Each obin As OperationBinding In bind.Operations
                        For Each oper As Operation In portType.Operations
                            If obin.Name.Equals(oper.Name) Then
                                Dim tnOper As TreeNode = TranslateOperation(port, obin, oper, protocol)
                                tnOper.ImageIndex = 11
                                tnOper.SelectedImageIndex = 11

                                If tnOper IsNot Nothing Then
                                    tnPort.Nodes.Add(tnOper)
                                End If


                            End If
                        Next
                    Next

                    tnPort.Expand()
                    tnService.Nodes.Add(tnPort)
                Next

                ServiceNode.Nodes.Add(tnService)
            Next
        End Sub
    End Class
End Namespace
