<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSortByStock = New System.Windows.Forms.Button()
        Me.btnSortByPrice = New System.Windows.Forms.Button()
        Me.btnSortByPE = New System.Windows.Forms.Button()
        Me.dgvStocks = New System.Windows.Forms.DataGridView()
        Me.Ticker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Earnings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOrder = New System.Windows.Forms.ComboBox()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSortByStock
        '
        Me.btnSortByStock.Location = New System.Drawing.Point(8, 19)
        Me.btnSortByStock.Name = "btnSortByStock"
        Me.btnSortByStock.Size = New System.Drawing.Size(104, 33)
        Me.btnSortByStock.TabIndex = 0
        Me.btnSortByStock.Text = "Sort By Stock"
        Me.btnSortByStock.UseVisualStyleBackColor = True
        '
        'btnSortByPrice
        '
        Me.btnSortByPrice.Location = New System.Drawing.Point(118, 19)
        Me.btnSortByPrice.Name = "btnSortByPrice"
        Me.btnSortByPrice.Size = New System.Drawing.Size(104, 33)
        Me.btnSortByPrice.TabIndex = 1
        Me.btnSortByPrice.Text = "Sort By Price"
        Me.btnSortByPrice.UseVisualStyleBackColor = True
        '
        'btnSortByPE
        '
        Me.btnSortByPE.Location = New System.Drawing.Point(228, 19)
        Me.btnSortByPE.Name = "btnSortByPE"
        Me.btnSortByPE.Size = New System.Drawing.Size(104, 33)
        Me.btnSortByPE.TabIndex = 2
        Me.btnSortByPE.Text = "Sort By PE"
        Me.btnSortByPE.UseVisualStyleBackColor = True
        '
        'dgvStocks
        '
        Me.dgvStocks.AllowUserToAddRows = False
        Me.dgvStocks.AllowUserToDeleteRows = False
        Me.dgvStocks.AllowUserToResizeColumns = False
        Me.dgvStocks.AllowUserToResizeRows = False
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ticker, Me.Price, Me.Earnings, Me.PE})
        Me.dgvStocks.Location = New System.Drawing.Point(8, 62)
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.ReadOnly = True
        Me.dgvStocks.RowTemplate.Height = 24
        Me.dgvStocks.Size = New System.Drawing.Size(444, 135)
        Me.dgvStocks.TabIndex = 3
        '
        'Ticker
        '
        Me.Ticker.HeaderText = "Ticker"
        Me.Ticker.Name = "Ticker"
        Me.Ticker.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Earnings
        '
        Me.Earnings.HeaderText = "Earnings"
        Me.Earnings.Name = "Earnings"
        Me.Earnings.ReadOnly = True
        '
        'PE
        '
        Me.PE.HeaderText = "PE"
        Me.PE.Name = "PE"
        Me.PE.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Order"
        '
        'cmbOrder
        '
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.FormattingEnabled = True
        Me.cmbOrder.Items.AddRange(New Object() {"Asc", "Dec"})
        Me.cmbOrder.Location = New System.Drawing.Point(338, 24)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(121, 24)
        Me.cmbOrder.TabIndex = 5
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 213)
        Me.Controls.Add(Me.cmbOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvStocks)
        Me.Controls.Add(Me.btnSortByPE)
        Me.Controls.Add(Me.btnSortByPrice)
        Me.Controls.Add(Me.btnSortByStock)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSortByStock As Button
    Friend WithEvents btnSortByPrice As Button
    Friend WithEvents btnSortByPE As Button
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents Ticker As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Earnings As DataGridViewTextBoxColumn
    Friend WithEvents PE As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOrder As ComboBox
End Class
