<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.txbN1 = New System.Windows.Forms.TextBox()
        Me.txbN2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.ForeColor = System.Drawing.Color.Black
        Me.lblSalida.Location = New System.Drawing.Point(124, 94)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(21, 13)
        Me.lblSalida.TabIndex = 0
        Me.lblSalida.Text = "res"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(103, 200)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 1
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'txbN1
        '
        Me.txbN1.Location = New System.Drawing.Point(12, 12)
        Me.txbN1.Name = "txbN1"
        Me.txbN1.Size = New System.Drawing.Size(100, 20)
        Me.txbN1.TabIndex = 2
        '
        'txbN2
        '
        Me.txbN2.Location = New System.Drawing.Point(172, 12)
        Me.txbN2.Name = "txbN2"
        Me.txbN2.Size = New System.Drawing.Size(100, 20)
        Me.txbN2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txbN2)
        Me.Controls.Add(Me.txbN1)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblSalida)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSalida As System.Windows.Forms.Label
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents txbN1 As System.Windows.Forms.TextBox
    Friend WithEvents txbN2 As System.Windows.Forms.TextBox

End Class
