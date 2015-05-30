<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeloDeReferênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WSDLToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OntologiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAWSDLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WSDLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WSDLToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarModeloDeReferênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoweringSchemaMappingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XSDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiftingSchemaMappingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoweringSchemaMappingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepositoryWebServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OntologyRecomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Location = New System.Drawing.Point(602, 131)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(247, 308)
        Me.TreeView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.RemoverToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 48)
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AdicionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoverToolStripMenuItem})
        Me.AdicionarToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Add_Icon_64
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AdicionarToolStripMenuItem.Text = "add"
        '
        'RemoverToolStripMenuItem
        '
        Me.RemoverToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.icon3
        Me.RemoverToolStripMenuItem.Name = "RemoverToolStripMenuItem"
        Me.RemoverToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RemoverToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoverToolStripMenuItem.Text = "model reference"
        '
        'RemoverToolStripMenuItem1
        '
        Me.RemoverToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeloDeReferênciaToolStripMenuItem})
        Me.RemoverToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.Delete_Icon_32
        Me.RemoverToolStripMenuItem1.Name = "RemoverToolStripMenuItem1"
        Me.RemoverToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.RemoverToolStripMenuItem1.Text = "remove"
        '
        'ModeloDeReferênciaToolStripMenuItem
        '
        Me.ModeloDeReferênciaToolStripMenuItem.Name = "ModeloDeReferênciaToolStripMenuItem"
        Me.ModeloDeReferênciaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ModeloDeReferênciaToolStripMenuItem.Text = "modelo de referência"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(521, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(275, 128)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(306, 311)
        Me.TextBox2.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.VisualizarToolStripMenuItem, Me.WSDLToolStripMenuItem, Me.AjudaToolStripMenuItem, Me.RepositoryWebServiceToolStripMenuItem, Me.OntologyRecomeToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WSDLToolStripMenuItem1, Me.OntologiaToolStripMenuItem, Me.SAWSDLToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AbrirToolStripMenuItem.Text = "Open"
        '
        'WSDLToolStripMenuItem1
        '
        Me.WSDLToolStripMenuItem1.Name = "WSDLToolStripMenuItem1"
        Me.WSDLToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.WSDLToolStripMenuItem1.Text = "WSDL 2.0 / XML Schema"
        '
        'OntologiaToolStripMenuItem
        '
        Me.OntologiaToolStripMenuItem.Name = "OntologiaToolStripMenuItem"
        Me.OntologiaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.OntologiaToolStripMenuItem.Text = "Ontology"
        '
        'SAWSDLToolStripMenuItem
        '
        Me.SAWSDLToolStripMenuItem.Name = "SAWSDLToolStripMenuItem"
        Me.SAWSDLToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SAWSDLToolStripMenuItem.Text = "SAWSDL"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'VisualizarToolStripMenuItem
        '
        Me.VisualizarToolStripMenuItem.Name = "VisualizarToolStripMenuItem"
        Me.VisualizarToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.VisualizarToolStripMenuItem.Text = "View"
        '
        'WSDLToolStripMenuItem
        '
        Me.WSDLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WSDLToolStripMenuItem2, Me.XSDToolStripMenuItem})
        Me.WSDLToolStripMenuItem.Name = "WSDLToolStripMenuItem"
        Me.WSDLToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.WSDLToolStripMenuItem.Text = "Document"
        '
        'WSDLToolStripMenuItem2
        '
        Me.WSDLToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarModeloDeReferênciaToolStripMenuItem, Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem})
        Me.WSDLToolStripMenuItem2.Name = "WSDLToolStripMenuItem2"
        Me.WSDLToolStripMenuItem2.Size = New System.Drawing.Size(105, 22)
        Me.WSDLToolStripMenuItem2.Text = "WSDL"
        '
        'AdicionarModeloDeReferênciaToolStripMenuItem
        '
        Me.AdicionarModeloDeReferênciaToolStripMenuItem.Name = "AdicionarModeloDeReferênciaToolStripMenuItem"
        Me.AdicionarModeloDeReferênciaToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.AdicionarModeloDeReferênciaToolStripMenuItem.Text = "Adicionar Modelo de Referência"
        '
        'AdicionarMapeamentoDeEsquemaToolStripMenuItem
        '
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiToolStripMenuItem, Me.LoweringSchemaMappingToolStripMenuItem})
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem.Name = "AdicionarMapeamentoDeEsquemaToolStripMenuItem"
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem.Text = "Adicionar Mapeamento de Esquema"
        '
        'LiToolStripMenuItem
        '
        Me.LiToolStripMenuItem.Name = "LiToolStripMenuItem"
        Me.LiToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.LiToolStripMenuItem.Text = "liftingSchemaMapping"
        '
        'LoweringSchemaMappingToolStripMenuItem
        '
        Me.LoweringSchemaMappingToolStripMenuItem.Name = "LoweringSchemaMappingToolStripMenuItem"
        Me.LoweringSchemaMappingToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.LoweringSchemaMappingToolStripMenuItem.Text = "loweringSchemaMapping"
        '
        'XSDToolStripMenuItem
        '
        Me.XSDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem1})
        Me.XSDToolStripMenuItem.Name = "XSDToolStripMenuItem"
        Me.XSDToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.XSDToolStripMenuItem.Text = "XSD"
        '
        'AdicionarMapeamentoDeEsquemaToolStripMenuItem1
        '
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiftingSchemaMappingToolStripMenuItem, Me.LoweringSchemaMappingToolStripMenuItem1})
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem1.Name = "AdicionarMapeamentoDeEsquemaToolStripMenuItem1"
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem1.Size = New System.Drawing.Size(266, 22)
        Me.AdicionarMapeamentoDeEsquemaToolStripMenuItem1.Text = "Adicionar Mapeamento de Esquema"
        '
        'LiftingSchemaMappingToolStripMenuItem
        '
        Me.LiftingSchemaMappingToolStripMenuItem.Name = "LiftingSchemaMappingToolStripMenuItem"
        Me.LiftingSchemaMappingToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.LiftingSchemaMappingToolStripMenuItem.Text = "liftingSchemaMapping"
        '
        'LoweringSchemaMappingToolStripMenuItem1
        '
        Me.LoweringSchemaMappingToolStripMenuItem1.Name = "LoweringSchemaMappingToolStripMenuItem1"
        Me.LoweringSchemaMappingToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.LoweringSchemaMappingToolStripMenuItem1.Text = "loweringSchemaMapping"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.RemoveToolStripMenuItem1})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.AjudaToolStripMenuItem.Text = "Ontology Repository "
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.AddToolStripMenuItem1.Text = "add"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.RemoveToolStripMenuItem1.Text = "remove"
        '
        'RepositoryWebServiceToolStripMenuItem
        '
        Me.RepositoryWebServiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.RepositoryWebServiceToolStripMenuItem.Name = "RepositoryWebServiceToolStripMenuItem"
        Me.RepositoryWebServiceToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.RepositoryWebServiceToolStripMenuItem.Text = "Web Service Repository "
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AddToolStripMenuItem.Text = "add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RemoveToolStripMenuItem.Text = "remove"
        '
        'OntologyRecomeToolStripMenuItem
        '
        Me.OntologyRecomeToolStripMenuItem.Checked = True
        Me.OntologyRecomeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OntologyRecomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem})
        Me.OntologyRecomeToolStripMenuItem.Name = "OntologyRecomeToolStripMenuItem"
        Me.OntologyRecomeToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.OntologyRecomeToolStripMenuItem.Text = "Ontology Recommender"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchToolStripMenuItem.Text = "search"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(609, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "WSDL/XML Schema"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ontology "
        '
        'TreeView2
        '
        Me.TreeView2.AllowDrop = True
        Me.TreeView2.Location = New System.Drawing.Point(14, 127)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(235, 311)
        Me.TreeView2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(57, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(522, 20)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(273, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "WSDL and XML Schema  Editor"
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 459)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 30)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(276, 459)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 30)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Verify WSDL and XML Schema  Editor"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.icon3
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(12, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 42)
        Me.Button3.TabIndex = 12
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.icon2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.Location = New System.Drawing.Point(110, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 491)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SWS Editor"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdicionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoverToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeloDeReferênciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WSDLToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WSDLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAWSDLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OntologiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WSDLToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarModeloDeReferênciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarMapeamentoDeEsquemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoweringSchemaMappingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XSDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarMapeamentoDeEsquemaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiftingSchemaMappingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoweringSchemaMappingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RepositoryWebServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OntologyRecomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
