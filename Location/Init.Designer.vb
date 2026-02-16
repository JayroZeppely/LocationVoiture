<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Init
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_search
        '
        Me.Btn_search.Location = New System.Drawing.Point(375, 308)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(125, 37)
        Me.Btn_search.TabIndex = 0
        Me.Btn_search.Text = "Lancer la recherche"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'Init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 574)
        Me.Controls.Add(Me.Btn_search)
        Me.Name = "Init"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_search As Button
End Class
