Imports System.Xml
Imports System.Web.Services.Description




Public Class Form1
    Sub treeView1_NodeMouseClick(ByVal sender As Object, _
    ByVal e As TreeNodeMouseClickEventArgs) _
    Handles TreeView1.NodeMouseClick

        TextBox2.Text = e.Node.Text

    End Sub 'treeView1_NodeMouseClick
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label1.Text = "Caminho do Arquivo"
        'Me.Label1.SetBounds(8, 8, 50, 20)
        '  Me.TextBox1.Text = Application.StartupPath & "\livros.xml"
        Me.TextBox1.Text = Application.StartupPath & "\passagemaerea.xml"

        Me.TextBox3.Text = Application.StartupPath & "\BOnSAI.xml"
        '  Me.TextBox1.SetBounds(64, 8, 256, 20)
        '  Me.Button1.Text = "Loading"
        '   Me.Button1.SetBounds(8, 40, 200, 20)
        Me.Text = "SWS Editor"
        'Me.Width = 336
        ' Me.Height = 368
        'Me.TreeView1.SetBounds(8, 72, 312, 264)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            Dim dom As New XmlDocument
            dom.Load("http://www.w3.org/2002/ws/sawsdl/spec/examples/mapping/OrderRequest2Ont.xslt")

            Me.TreeView1.Nodes.Clear()

            TreeView1.Nodes.Add(New TreeNode(dom.DocumentElement.Name))
            Dim tNode As New TreeNode()
            tNode = TreeView1.Nodes(0)

            '    ' SECTION 3. Populate the TreeView with the DOM nodes.
            AddNode(dom.DocumentElement, tNode)
            TreeView1.ExpandAll()

        Catch xmlEx As XmlException
            MessageBox.Show(xmlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try






    End Sub


    Private Sub ReadServiceDescription()


        Try
            Me.Cursor = Cursors.WaitCursor

            Dim reader As New XmlTextReader(TextBox1.Text)

            Dim service As ServiceDescription = ServiceDescription.Read(reader, False)

            ' Dim parser As New WSDLParser(service)

            ' Me.TreeView1.Nodes.Add(parser.ServiceNode)
            'http://soap.amazon.com/schemas2/AmazonWebServices.wsdl 
            'http://glkev.webs.innerhost.com/glkev_ws/weatherfetcher.asmx?wsdl
            ' Me.TextBox1.Text.Items.Add(TextBox1.Text)
        Catch e As Exception
            MessageBox.Show("Chamada ao Serviço Structural Validation " + "Documento WSDL inválido " + e.Message.ToString())
        Finally
            Me.Cursor = Cursors.[Default]
        End Try

    End Sub
    Private Sub AddNode(ByRef inXmlNode As XmlNode, ByRef inTreeNode As TreeNode)
        Dim xNode As XmlNode
        Dim tNode As TreeNode
        Dim nodeList As XmlNodeList
        Dim i As Integer

        ' Loop through the XML nodes until the leaf is reached.
        ' Add the nodes to the TreeView during the looping process.
        If inXmlNode.HasChildNodes() Then
            nodeList = inXmlNode.ChildNodes
            For i = 0 To nodeList.Count - 1
                xNode = inXmlNode.ChildNodes(i)
                inTreeNode.Nodes.Add(New TreeNode(xNode.Name))
                tNode = inTreeNode.Nodes(i)
                AddNode(xNode, tNode)
            Next
        Else
            ' Here you need to pull the data from the XmlNode based on the
            ' type of node, whether attribute values are required, and so forth.
            inTreeNode.Text = (inXmlNode.OuterXml).Trim
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub RemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub WSDLToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WSDLToolStripMenuItem1.Click



    End Sub

    Private Sub WSDLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WSDLToolStripMenuItem.Click

    End Sub

    Private Sub AdicionarMapeamentoDeEsquemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarMapeamentoDeEsquemaToolStripMenuItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim dom As New XmlDocument
            dom.Load("http://lpis.csd.auth.gr/ontologies/CoDAMoS/CoDAMoS.owl")

            Me.TreeView2.Nodes.Clear()

            TreeView2.Nodes.Add(New TreeNode(dom.DocumentElement.Name))
            Dim tNode As New TreeNode()
            tNode = TreeView2.Nodes(0)

            ' SECTION 3. Populate the TreeView with the DOM nodes.
            AddNode(dom.DocumentElement, tNode)
            TreeView2.ExpandAll()

        Catch xmlEx As XmlException
            MessageBox.Show(xmlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click

    End Sub

    Private Sub RepositoryWebServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepositoryWebServiceToolStripMenuItem.Click
        Dim form As New Form3()
        form.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim form As New Form2()
        form.Show()
    End Sub

    Private Sub OntologyRecomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OntologyRecomeToolStripMenuItem.Click
        Dim form As New Form2()
        form.Show()
    End Sub
End Class
