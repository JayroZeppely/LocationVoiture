<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recherche
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.main_title_init = New System.Windows.Forms.Label()
        Me.adresse_depart = New System.Windows.Forms.TextBox()
        Me.adresse_retour = New System.Windows.Forms.TextBox()
        Me.location_multiple = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.options = New System.Windows.Forms.GroupBox()
        Me.nombre_place = New System.Windows.Forms.Label()
        Me.Label4_place_min = New System.Windows.Forms.Label()
        Me.Label4_place_max = New System.Windows.Forms.Label()
        Me.place_max = New System.Windows.Forms.NumericUpDown()
        Me.place_min = New System.Windows.Forms.NumericUpDown()
        Me.Label_pix_max = New System.Windows.Forms.Label()
        Me.Label_prix_min = New System.Windows.Forms.Label()
        Me.prix_max = New System.Windows.Forms.TextBox()
        Me.prix_min = New System.Windows.Forms.TextBox()
        Me.prix = New System.Windows.Forms.Label()
        Me.automatique = New System.Windows.Forms.RadioButton()
        Me.manuelle = New System.Windows.Forms.RadioButton()
        Me.transmission = New System.Windows.Forms.Label()
        Me.porte_velos = New System.Windows.Forms.CheckBox()
        Me.regulateur = New System.Windows.Forms.CheckBox()
        Me.climatisation = New System.Windows.Forms.CheckBox()
        Me.gps = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_distance = New System.Windows.Forms.Label()
        Me.distance = New System.Windows.Forms.Label()
        Me.TrackBar_distance = New System.Windows.Forms.TrackBar()
        Me.caracteristiques = New System.Windows.Forms.Label()
        Me.utilitaire = New System.Windows.Forms.CheckBox()
        Me.voiture = New System.Windows.Forms.CheckBox()
        Me.Label_options = New System.Windows.Forms.Label()
        Me.lieu_depart = New System.Windows.Forms.Label()
        Me.lieu_retour = New System.Windows.Forms.Label()
        Me.date_debut = New System.Windows.Forms.Label()
        Me.date_retour = New System.Windows.Forms.Label()
        Me.options.SuspendLayout()
        CType(Me.place_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.place_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_distance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_search
        '
        Me.Btn_search.Location = New System.Drawing.Point(435, 292)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(125, 37)
        Me.Btn_search.TabIndex = 0
        Me.Btn_search.Text = "Lancer la recherche"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(392, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(137, 215)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'main_title_init
        '
        Me.main_title_init.AutoSize = True
        Me.main_title_init.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_title_init.Location = New System.Drawing.Point(130, 64)
        Me.main_title_init.Name = "main_title_init"
        Me.main_title_init.Size = New System.Drawing.Size(351, 37)
        Me.main_title_init.TabIndex = 4
        Me.main_title_init.Text = "Chercher une location"
        '
        'adresse_depart
        '
        Me.adresse_depart.Location = New System.Drawing.Point(137, 144)
        Me.adresse_depart.Name = "adresse_depart"
        Me.adresse_depart.Size = New System.Drawing.Size(200, 20)
        Me.adresse_depart.TabIndex = 5
        Me.adresse_depart.Text = " 7 avenue Edouard Belin 31400 TOULOUSE"
        '
        'adresse_retour
        '
        Me.adresse_retour.Location = New System.Drawing.Point(392, 144)
        Me.adresse_retour.Name = "adresse_retour"
        Me.adresse_retour.Size = New System.Drawing.Size(200, 20)
        Me.adresse_retour.TabIndex = 6
        '
        'location_multiple
        '
        Me.location_multiple.AutoSize = True
        Me.location_multiple.Location = New System.Drawing.Point(25, 79)
        Me.location_multiple.Name = "location_multiple"
        Me.location_multiple.Size = New System.Drawing.Size(145, 17)
        Me.location_multiple.TabIndex = 3
        Me.location_multiple.Text = "Louer plusieurs véhicules"
        Me.location_multiple.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type de véhicule"
        '
        'options
        '
        Me.options.Controls.Add(Me.nombre_place)
        Me.options.Controls.Add(Me.Label4_place_min)
        Me.options.Controls.Add(Me.Label4_place_max)
        Me.options.Controls.Add(Me.place_max)
        Me.options.Controls.Add(Me.place_min)
        Me.options.Controls.Add(Me.Label_pix_max)
        Me.options.Controls.Add(Me.Label_prix_min)
        Me.options.Controls.Add(Me.prix_max)
        Me.options.Controls.Add(Me.prix_min)
        Me.options.Controls.Add(Me.prix)
        Me.options.Controls.Add(Me.automatique)
        Me.options.Controls.Add(Me.manuelle)
        Me.options.Controls.Add(Me.transmission)
        Me.options.Controls.Add(Me.porte_velos)
        Me.options.Controls.Add(Me.regulateur)
        Me.options.Controls.Add(Me.climatisation)
        Me.options.Controls.Add(Me.gps)
        Me.options.Controls.Add(Me.Label2)
        Me.options.Controls.Add(Me.label_distance)
        Me.options.Controls.Add(Me.distance)
        Me.options.Controls.Add(Me.TrackBar_distance)
        Me.options.Controls.Add(Me.caracteristiques)
        Me.options.Controls.Add(Me.utilitaire)
        Me.options.Controls.Add(Me.voiture)
        Me.options.Controls.Add(Me.Label1)
        Me.options.Controls.Add(Me.location_multiple)
        Me.options.Location = New System.Drawing.Point(12, 335)
        Me.options.Name = "options"
        Me.options.Size = New System.Drawing.Size(771, 326)
        Me.options.TabIndex = 8
        Me.options.TabStop = False
        Me.options.Visible = False
        '
        'nombre_place
        '
        Me.nombre_place.AutoSize = True
        Me.nombre_place.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_place.Location = New System.Drawing.Point(376, 201)
        Me.nombre_place.Name = "nombre_place"
        Me.nombre_place.Size = New System.Drawing.Size(137, 20)
        Me.nombre_place.TabIndex = 32
        Me.nombre_place.Text = "Nombre de places"
        '
        'Label4_place_min
        '
        Me.Label4_place_min.AutoSize = True
        Me.Label4_place_min.Location = New System.Drawing.Point(377, 233)
        Me.Label4_place_min.Name = "Label4_place_min"
        Me.Label4_place_min.Size = New System.Drawing.Size(24, 13)
        Me.Label4_place_min.TabIndex = 31
        Me.Label4_place_min.Text = "Min"
        '
        'Label4_place_max
        '
        Me.Label4_place_max.AutoSize = True
        Me.Label4_place_max.Location = New System.Drawing.Point(511, 233)
        Me.Label4_place_max.Name = "Label4_place_max"
        Me.Label4_place_max.Size = New System.Drawing.Size(27, 13)
        Me.Label4_place_max.TabIndex = 30
        Me.Label4_place_max.Text = "Max"
        '
        'place_max
        '
        Me.place_max.Location = New System.Drawing.Point(544, 231)
        Me.place_max.Name = "place_max"
        Me.place_max.Size = New System.Drawing.Size(40, 20)
        Me.place_max.TabIndex = 29
        '
        'place_min
        '
        Me.place_min.Location = New System.Drawing.Point(410, 231)
        Me.place_min.Name = "place_min"
        Me.place_min.Size = New System.Drawing.Size(40, 20)
        Me.place_min.TabIndex = 28
        '
        'Label_pix_max
        '
        Me.Label_pix_max.AutoSize = True
        Me.Label_pix_max.Location = New System.Drawing.Point(152, 236)
        Me.Label_pix_max.Name = "Label_pix_max"
        Me.Label_pix_max.Size = New System.Drawing.Size(27, 13)
        Me.Label_pix_max.TabIndex = 27
        Me.Label_pix_max.Text = "Max"
        '
        'Label_prix_min
        '
        Me.Label_prix_min.AutoSize = True
        Me.Label_prix_min.Location = New System.Drawing.Point(26, 236)
        Me.Label_prix_min.Name = "Label_prix_min"
        Me.Label_prix_min.Size = New System.Drawing.Size(24, 13)
        Me.Label_prix_min.TabIndex = 26
        Me.Label_prix_min.Text = "Min"
        '
        'prix_max
        '
        Me.prix_max.Location = New System.Drawing.Point(185, 233)
        Me.prix_max.Name = "prix_max"
        Me.prix_max.Size = New System.Drawing.Size(41, 20)
        Me.prix_max.TabIndex = 24
        '
        'prix_min
        '
        Me.prix_min.Location = New System.Drawing.Point(56, 233)
        Me.prix_min.Name = "prix_min"
        Me.prix_min.Size = New System.Drawing.Size(41, 20)
        Me.prix_min.TabIndex = 23
        '
        'prix
        '
        Me.prix.AutoSize = True
        Me.prix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(21, 197)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(247, 24)
        Me.prix.TabIndex = 22
        Me.prix.Text = "Fourchette de prix journalier"
        '
        'automatique
        '
        Me.automatique.AutoSize = True
        Me.automatique.Location = New System.Drawing.Point(454, 149)
        Me.automatique.Name = "automatique"
        Me.automatique.Size = New System.Drawing.Size(84, 17)
        Me.automatique.TabIndex = 21
        Me.automatique.TabStop = True
        Me.automatique.Text = "Automatique"
        Me.automatique.UseVisualStyleBackColor = True
        '
        'manuelle
        '
        Me.manuelle.AutoSize = True
        Me.manuelle.Location = New System.Drawing.Point(380, 149)
        Me.manuelle.Name = "manuelle"
        Me.manuelle.Size = New System.Drawing.Size(68, 17)
        Me.manuelle.TabIndex = 20
        Me.manuelle.TabStop = True
        Me.manuelle.Text = "Manuelle"
        Me.manuelle.UseVisualStyleBackColor = True
        '
        'transmission
        '
        Me.transmission.AutoSize = True
        Me.transmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transmission.Location = New System.Drawing.Point(376, 122)
        Me.transmission.Name = "transmission"
        Me.transmission.Size = New System.Drawing.Size(102, 20)
        Me.transmission.TabIndex = 19
        Me.transmission.Text = "Transmission"
        '
        'porte_velos
        '
        Me.porte_velos.Appearance = System.Windows.Forms.Appearance.Button
        Me.porte_velos.Location = New System.Drawing.Point(640, 79)
        Me.porte_velos.Name = "porte_velos"
        Me.porte_velos.Size = New System.Drawing.Size(80, 23)
        Me.porte_velos.TabIndex = 18
        Me.porte_velos.Text = "Porte-vélos"
        Me.porte_velos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.porte_velos.UseVisualStyleBackColor = True
        '
        'regulateur
        '
        Me.regulateur.Appearance = System.Windows.Forms.Appearance.Button
        Me.regulateur.Location = New System.Drawing.Point(554, 79)
        Me.regulateur.Name = "regulateur"
        Me.regulateur.Size = New System.Drawing.Size(80, 23)
        Me.regulateur.TabIndex = 17
        Me.regulateur.Text = "Régulateur"
        Me.regulateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.regulateur.UseVisualStyleBackColor = True
        '
        'climatisation
        '
        Me.climatisation.Appearance = System.Windows.Forms.Appearance.Button
        Me.climatisation.Location = New System.Drawing.Point(468, 79)
        Me.climatisation.Name = "climatisation"
        Me.climatisation.Size = New System.Drawing.Size(80, 23)
        Me.climatisation.TabIndex = 16
        Me.climatisation.Text = "Climatisation"
        Me.climatisation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.climatisation.UseVisualStyleBackColor = True
        '
        'gps
        '
        Me.gps.Appearance = System.Windows.Forms.Appearance.Button
        Me.gps.Location = New System.Drawing.Point(380, 79)
        Me.gps.Name = "gps"
        Me.gps.Size = New System.Drawing.Size(80, 23)
        Me.gps.TabIndex = 15
        Me.gps.Text = "GPS"
        Me.gps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.gps.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Equipements"
        '
        'label_distance
        '
        Me.label_distance.AutoSize = True
        Me.label_distance.Location = New System.Drawing.Point(265, 149)
        Me.label_distance.Name = "label_distance"
        Me.label_distance.Size = New System.Drawing.Size(39, 13)
        Me.label_distance.TabIndex = 13
        Me.label_distance.Text = "Label2"
        '
        'distance
        '
        Me.distance.AutoSize = True
        Me.distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distance.Location = New System.Drawing.Point(21, 122)
        Me.distance.Name = "distance"
        Me.distance.Size = New System.Drawing.Size(82, 24)
        Me.distance.TabIndex = 12
        Me.distance.Text = "Distance"
        '
        'TrackBar_distance
        '
        Me.TrackBar_distance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar_distance.Location = New System.Drawing.Point(25, 149)
        Me.TrackBar_distance.Name = "TrackBar_distance"
        Me.TrackBar_distance.Size = New System.Drawing.Size(233, 45)
        Me.TrackBar_distance.TabIndex = 11
        '
        'caracteristiques
        '
        Me.caracteristiques.AutoSize = True
        Me.caracteristiques.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caracteristiques.Location = New System.Drawing.Point(376, 16)
        Me.caracteristiques.Name = "caracteristiques"
        Me.caracteristiques.Size = New System.Drawing.Size(246, 24)
        Me.caracteristiques.TabIndex = 10
        Me.caracteristiques.Text = "Caractéristiques du véhicule"
        '
        'utilitaire
        '
        Me.utilitaire.AutoSize = True
        Me.utilitaire.Location = New System.Drawing.Point(90, 56)
        Me.utilitaire.Name = "utilitaire"
        Me.utilitaire.Size = New System.Drawing.Size(63, 17)
        Me.utilitaire.TabIndex = 9
        Me.utilitaire.Text = "Utilitaire"
        Me.utilitaire.UseVisualStyleBackColor = True
        '
        'voiture
        '
        Me.voiture.AutoSize = True
        Me.voiture.Location = New System.Drawing.Point(25, 56)
        Me.voiture.Name = "voiture"
        Me.voiture.Size = New System.Drawing.Size(59, 17)
        Me.voiture.TabIndex = 8
        Me.voiture.Text = "Voiture"
        Me.voiture.UseVisualStyleBackColor = True
        '
        'Label_options
        '
        Me.Label_options.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_options.Location = New System.Drawing.Point(160, 316)
        Me.Label_options.Name = "Label_options"
        Me.Label_options.Size = New System.Drawing.Size(120, 23)
        Me.Label_options.TabIndex = 0
        Me.Label_options.Text = "Options avancées " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             ▼"
        '
        'lieu_depart
        '
        Me.lieu_depart.AutoSize = True
        Me.lieu_depart.Location = New System.Drawing.Point(137, 125)
        Me.lieu_depart.Name = "lieu_depart"
        Me.lieu_depart.Size = New System.Drawing.Size(81, 13)
        Me.lieu_depart.TabIndex = 9
        Me.lieu_depart.Text = "Lieu de départ :"
        '
        'lieu_retour
        '
        Me.lieu_retour.AutoSize = True
        Me.lieu_retour.Location = New System.Drawing.Point(394, 125)
        Me.lieu_retour.Name = "lieu_retour"
        Me.lieu_retour.Size = New System.Drawing.Size(78, 13)
        Me.lieu_retour.TabIndex = 10
        Me.lieu_retour.Text = "Lieu de retour :"
        '
        'date_debut
        '
        Me.date_debut.AutoSize = True
        Me.date_debut.Location = New System.Drawing.Point(137, 199)
        Me.date_debut.Name = "date_debut"
        Me.date_debut.Size = New System.Drawing.Size(81, 13)
        Me.date_debut.TabIndex = 11
        Me.date_debut.Text = "Date de début :"
        '
        'date_retour
        '
        Me.date_retour.AutoSize = True
        Me.date_retour.Location = New System.Drawing.Point(394, 199)
        Me.date_retour.Name = "date_retour"
        Me.date_retour.Size = New System.Drawing.Size(81, 13)
        Me.date_retour.TabIndex = 12
        Me.date_retour.Text = "Date de retour :"
        '
        'Recherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 688)
        Me.Controls.Add(Me.date_retour)
        Me.Controls.Add(Me.date_debut)
        Me.Controls.Add(Me.lieu_retour)
        Me.Controls.Add(Me.lieu_depart)
        Me.Controls.Add(Me.Label_options)
        Me.Controls.Add(Me.options)
        Me.Controls.Add(Me.adresse_retour)
        Me.Controls.Add(Me.adresse_depart)
        Me.Controls.Add(Me.main_title_init)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Btn_search)
        Me.Name = "Recherche"
        Me.Text = "Recherche"
        Me.options.ResumeLayout(False)
        Me.options.PerformLayout()
        CType(Me.place_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.place_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_distance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_search As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents main_title_init As Label
    Friend WithEvents adresse_depart As TextBox
    Friend WithEvents adresse_retour As TextBox
    Friend WithEvents location_multiple As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents options As GroupBox
    Friend WithEvents gps As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label_distance As Label
    Friend WithEvents distance As Label
    Friend WithEvents TrackBar_distance As TrackBar
    Friend WithEvents caracteristiques As Label
    Friend WithEvents utilitaire As CheckBox
    Friend WithEvents voiture As CheckBox
    Friend WithEvents porte_velos As CheckBox
    Friend WithEvents regulateur As CheckBox
    Friend WithEvents climatisation As CheckBox
    Friend WithEvents manuelle As RadioButton
    Friend WithEvents transmission As Label
    Friend WithEvents automatique As RadioButton
    Friend WithEvents Label_pix_max As Label
    Friend WithEvents Label_prix_min As Label
    Friend WithEvents prix_max As TextBox
    Friend WithEvents prix_min As TextBox
    Friend WithEvents prix As Label
    Friend WithEvents Label4_place_max As Label
    Friend WithEvents place_max As NumericUpDown
    Friend WithEvents place_min As NumericUpDown
    Friend WithEvents nombre_place As Label
    Friend WithEvents Label4_place_min As Label
    Friend WithEvents Label_options As Label
    Friend WithEvents lieu_depart As Label
    Friend WithEvents lieu_retour As Label
    Friend WithEvents date_debut As Label
    Friend WithEvents date_retour As Label
End Class
