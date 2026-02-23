<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.date_retour = New System.Windows.Forms.Label()
        Me.date_debut = New System.Windows.Forms.Label()
        Me.reservation_title = New System.Windows.Forms.Label()
        Me.date_debut_resa = New System.Windows.Forms.DateTimePicker()
        Me.date_retour_resa = New System.Windows.Forms.DateTimePicker()
        Me.prix_total_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_confirmer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'date_retour
        '
        Me.date_retour.AutoSize = True
        Me.date_retour.Location = New System.Drawing.Point(297, 113)
        Me.date_retour.Name = "date_retour"
        Me.date_retour.Size = New System.Drawing.Size(81, 13)
        Me.date_retour.TabIndex = 21
        Me.date_retour.Text = "Date de retour :"
        '
        'date_debut
        '
        Me.date_debut.AutoSize = True
        Me.date_debut.Location = New System.Drawing.Point(40, 113)
        Me.date_debut.Name = "date_debut"
        Me.date_debut.Size = New System.Drawing.Size(81, 13)
        Me.date_debut.TabIndex = 20
        Me.date_debut.Text = "Date de début :"
        '
        'reservation_title
        '
        Me.reservation_title.AutoSize = True
        Me.reservation_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservation_title.Location = New System.Drawing.Point(165, 46)
        Me.reservation_title.Name = "reservation_title"
        Me.reservation_title.Size = New System.Drawing.Size(196, 37)
        Me.reservation_title.TabIndex = 15
        Me.reservation_title.Text = "Réservation"
        '
        'date_debut_resa
        '
        Me.date_debut_resa.Location = New System.Drawing.Point(40, 129)
        Me.date_debut_resa.Name = "date_debut_resa"
        Me.date_debut_resa.Size = New System.Drawing.Size(200, 20)
        Me.date_debut_resa.TabIndex = 14
        '
        'date_retour_resa
        '
        Me.date_retour_resa.Location = New System.Drawing.Point(295, 129)
        Me.date_retour_resa.Name = "date_retour_resa"
        Me.date_retour_resa.Size = New System.Drawing.Size(200, 20)
        Me.date_retour_resa.TabIndex = 13
        '
        'prix_total_label
        '
        Me.prix_total_label.AutoSize = True
        Me.prix_total_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix_total_label.Location = New System.Drawing.Point(221, 211)
        Me.prix_total_label.Name = "prix_total_label"
        Me.prix_total_label.Size = New System.Drawing.Size(84, 24)
        Me.prix_total_label.TabIndex = 36
        Me.prix_total_label.Text = "Tarif total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 29)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "355€"
        '
        'Btn_confirmer
        '
        Me.Btn_confirmer.Location = New System.Drawing.Point(370, 306)
        Me.Btn_confirmer.Name = "Btn_confirmer"
        Me.Btn_confirmer.Size = New System.Drawing.Size(125, 37)
        Me.Btn_confirmer.TabIndex = 37
        Me.Btn_confirmer.Text = "Confirmer"
        Me.Btn_confirmer.UseVisualStyleBackColor = True
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 370)
        Me.Controls.Add(Me.Btn_confirmer)
        Me.Controls.Add(Me.prix_total_label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.date_retour)
        Me.Controls.Add(Me.date_debut)
        Me.Controls.Add(Me.reservation_title)
        Me.Controls.Add(Me.date_debut_resa)
        Me.Controls.Add(Me.date_retour_resa)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents date_retour As Label
    Friend WithEvents date_debut As Label
    Friend WithEvents reservation_title As Label
    Friend WithEvents date_debut_resa As DateTimePicker
    Friend WithEvents date_retour_resa As DateTimePicker
    Friend WithEvents prix_total_label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_confirmer As Button
End Class
