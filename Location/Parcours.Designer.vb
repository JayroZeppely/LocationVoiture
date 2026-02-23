<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parcours
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
        Me.Btn_reserver = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.exemple1 = New System.Windows.Forms.GroupBox()
        Me.ville1 = New System.Windows.Forms.Label()
        Me.loueur1 = New System.Windows.Forms.Label()
        Me.exemple2 = New System.Windows.Forms.GroupBox()
        Me.ville2 = New System.Windows.Forms.Label()
        Me.loueur2 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.location_multiple = New System.Windows.Forms.CheckBox()
        Me.filtres = New System.Windows.Forms.Label()
        Me.nom_annonce = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.loueur = New System.Windows.Forms.Label()
        Me.lieu_annonce = New System.Windows.Forms.Label()
        Me.prix_journalier = New System.Windows.Forms.Label()
        Me.disponibilités = New System.Windows.Forms.Label()
        Me.a_propos = New System.Windows.Forms.Label()
        Me.equipements_detail = New System.Windows.Forms.Label()
        Me.transmission_detail = New System.Windows.Forms.Label()
        Me.places_detail = New System.Windows.Forms.Label()
        Me.kilometrage_detail = New System.Windows.Forms.Label()
        Me.distance_detail = New System.Windows.Forms.Label()
        Me.annonce_detail = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prix_total_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.photo_exemple1 = New System.Windows.Forms.PictureBox()
        Me.photo_exemple2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.exemple1.SuspendLayout()
        Me.exemple2.SuspendLayout()
        Me.options.SuspendLayout()
        CType(Me.place_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.place_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_distance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.annonce_detail.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photo_exemple1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photo_exemple2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_reserver
        '
        Me.Btn_reserver.Location = New System.Drawing.Point(256, 198)
        Me.Btn_reserver.Name = "Btn_reserver"
        Me.Btn_reserver.Size = New System.Drawing.Size(125, 37)
        Me.Btn_reserver.TabIndex = 1
        Me.Btn_reserver.Text = "Réserver"
        Me.Btn_reserver.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(326, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 669)
        Me.Panel1.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.exemple1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.exemple2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(223, 147)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'exemple1
        '
        Me.exemple1.Controls.Add(Me.photo_exemple1)
        Me.exemple1.Controls.Add(Me.ville1)
        Me.exemple1.Controls.Add(Me.loueur1)
        Me.exemple1.Location = New System.Drawing.Point(4, 4)
        Me.exemple1.Name = "exemple1"
        Me.exemple1.Size = New System.Drawing.Size(184, 64)
        Me.exemple1.TabIndex = 17
        Me.exemple1.TabStop = False
        '
        'ville1
        '
        Me.ville1.AutoSize = True
        Me.ville1.Location = New System.Drawing.Point(77, 39)
        Me.ville1.Name = "ville1"
        Me.ville1.Size = New System.Drawing.Size(51, 13)
        Me.ville1.TabIndex = 15
        Me.ville1.Text = "Toulouse"
        '
        'loueur1
        '
        Me.loueur1.AutoSize = True
        Me.loueur1.Location = New System.Drawing.Point(77, 19)
        Me.loueur1.Name = "loueur1"
        Me.loueur1.Size = New System.Drawing.Size(59, 13)
        Me.loueur1.TabIndex = 1
        Me.loueur1.Text = "Jerry Goller"
        '
        'exemple2
        '
        Me.exemple2.Controls.Add(Me.photo_exemple2)
        Me.exemple2.Controls.Add(Me.ville2)
        Me.exemple2.Controls.Add(Me.loueur2)
        Me.exemple2.Location = New System.Drawing.Point(4, 77)
        Me.exemple2.Name = "exemple2"
        Me.exemple2.Size = New System.Drawing.Size(184, 64)
        Me.exemple2.TabIndex = 16
        Me.exemple2.TabStop = False
        '
        'ville2
        '
        Me.ville2.AutoSize = True
        Me.ville2.Location = New System.Drawing.Point(77, 39)
        Me.ville2.Name = "ville2"
        Me.ville2.Size = New System.Drawing.Size(51, 13)
        Me.ville2.TabIndex = 15
        Me.ville2.Text = "Toulouse"
        '
        'loueur2
        '
        Me.loueur2.AutoSize = True
        Me.loueur2.Location = New System.Drawing.Point(77, 19)
        Me.loueur2.Name = "loueur2"
        Me.loueur2.Size = New System.Drawing.Size(59, 13)
        Me.loueur2.TabIndex = 1
        Me.loueur2.Text = "Jerry Goller"
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
        Me.options.Location = New System.Drawing.Point(12, 66)
        Me.options.Name = "options"
        Me.options.Size = New System.Drawing.Size(305, 540)
        Me.options.TabIndex = 9
        Me.options.TabStop = False
        '
        'nombre_place
        '
        Me.nombre_place.AutoSize = True
        Me.nombre_place.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_place.Location = New System.Drawing.Point(21, 318)
        Me.nombre_place.Name = "nombre_place"
        Me.nombre_place.Size = New System.Drawing.Size(137, 20)
        Me.nombre_place.TabIndex = 32
        Me.nombre_place.Text = "Nombre de places"
        '
        'Label4_place_min
        '
        Me.Label4_place_min.AutoSize = True
        Me.Label4_place_min.Location = New System.Drawing.Point(22, 350)
        Me.Label4_place_min.Name = "Label4_place_min"
        Me.Label4_place_min.Size = New System.Drawing.Size(24, 13)
        Me.Label4_place_min.TabIndex = 31
        Me.Label4_place_min.Text = "Min"
        '
        'Label4_place_max
        '
        Me.Label4_place_max.AutoSize = True
        Me.Label4_place_max.Location = New System.Drawing.Point(156, 350)
        Me.Label4_place_max.Name = "Label4_place_max"
        Me.Label4_place_max.Size = New System.Drawing.Size(27, 13)
        Me.Label4_place_max.TabIndex = 30
        Me.Label4_place_max.Text = "Max"
        '
        'place_max
        '
        Me.place_max.Location = New System.Drawing.Point(189, 348)
        Me.place_max.Name = "place_max"
        Me.place_max.Size = New System.Drawing.Size(40, 20)
        Me.place_max.TabIndex = 29
        '
        'place_min
        '
        Me.place_min.Location = New System.Drawing.Point(55, 348)
        Me.place_min.Name = "place_min"
        Me.place_min.Size = New System.Drawing.Size(40, 20)
        Me.place_min.TabIndex = 28
        '
        'Label_pix_max
        '
        Me.Label_pix_max.AutoSize = True
        Me.Label_pix_max.Location = New System.Drawing.Point(137, 501)
        Me.Label_pix_max.Name = "Label_pix_max"
        Me.Label_pix_max.Size = New System.Drawing.Size(27, 13)
        Me.Label_pix_max.TabIndex = 27
        Me.Label_pix_max.Text = "Max"
        '
        'Label_prix_min
        '
        Me.Label_prix_min.AutoSize = True
        Me.Label_prix_min.Location = New System.Drawing.Point(11, 501)
        Me.Label_prix_min.Name = "Label_prix_min"
        Me.Label_prix_min.Size = New System.Drawing.Size(24, 13)
        Me.Label_prix_min.TabIndex = 26
        Me.Label_prix_min.Text = "Min"
        '
        'prix_max
        '
        Me.prix_max.Location = New System.Drawing.Point(170, 498)
        Me.prix_max.Name = "prix_max"
        Me.prix_max.Size = New System.Drawing.Size(41, 20)
        Me.prix_max.TabIndex = 24
        '
        'prix_min
        '
        Me.prix_min.Location = New System.Drawing.Point(41, 498)
        Me.prix_min.Name = "prix_min"
        Me.prix_min.Size = New System.Drawing.Size(41, 20)
        Me.prix_min.TabIndex = 23
        '
        'prix
        '
        Me.prix.AutoSize = True
        Me.prix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(6, 462)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(247, 24)
        Me.prix.TabIndex = 22
        Me.prix.Text = "Fourchette de prix journalier"
        '
        'automatique
        '
        Me.automatique.AutoSize = True
        Me.automatique.Location = New System.Drawing.Point(99, 280)
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
        Me.manuelle.Location = New System.Drawing.Point(25, 280)
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
        Me.transmission.Location = New System.Drawing.Point(21, 253)
        Me.transmission.Name = "transmission"
        Me.transmission.Size = New System.Drawing.Size(102, 20)
        Me.transmission.TabIndex = 19
        Me.transmission.Text = "Transmission"
        '
        'porte_velos
        '
        Me.porte_velos.Appearance = System.Windows.Forms.Appearance.Button
        Me.porte_velos.Location = New System.Drawing.Point(113, 208)
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
        Me.regulateur.Location = New System.Drawing.Point(25, 208)
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
        Me.climatisation.Location = New System.Drawing.Point(113, 179)
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
        Me.gps.Location = New System.Drawing.Point(25, 179)
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
        Me.Label2.Location = New System.Drawing.Point(21, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Equipements"
        '
        'label_distance
        '
        Me.label_distance.AutoSize = True
        Me.label_distance.Location = New System.Drawing.Point(250, 414)
        Me.label_distance.Name = "label_distance"
        Me.label_distance.Size = New System.Drawing.Size(30, 13)
        Me.label_distance.TabIndex = 13
        Me.label_distance.Text = "0 km"
        '
        'distance
        '
        Me.distance.AutoSize = True
        Me.distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distance.Location = New System.Drawing.Point(6, 387)
        Me.distance.Name = "distance"
        Me.distance.Size = New System.Drawing.Size(82, 24)
        Me.distance.TabIndex = 12
        Me.distance.Text = "Distance"
        '
        'TrackBar_distance
        '
        Me.TrackBar_distance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar_distance.Location = New System.Drawing.Point(10, 414)
        Me.TrackBar_distance.Maximum = 100
        Me.TrackBar_distance.Name = "TrackBar_distance"
        Me.TrackBar_distance.Size = New System.Drawing.Size(233, 45)
        Me.TrackBar_distance.TabIndex = 11
        Me.TrackBar_distance.TickFrequency = 5
        '
        'caracteristiques
        '
        Me.caracteristiques.AutoSize = True
        Me.caracteristiques.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caracteristiques.Location = New System.Drawing.Point(21, 116)
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
        'filtres
        '
        Me.filtres.AutoSize = True
        Me.filtres.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtres.Location = New System.Drawing.Point(12, 32)
        Me.filtres.Name = "filtres"
        Me.filtres.Size = New System.Drawing.Size(89, 31)
        Me.filtres.TabIndex = 10
        Me.filtres.Text = "Filtres"
        '
        'nom_annonce
        '
        Me.nom_annonce.AutoSize = True
        Me.nom_annonce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_annonce.Location = New System.Drawing.Point(177, 19)
        Me.nom_annonce.Name = "nom_annonce"
        Me.nom_annonce.Size = New System.Drawing.Size(166, 24)
        Me.nom_annonce.TabIndex = 14
        Me.nom_annonce.Text = "Nom de l'annonce"
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.Location = New System.Drawing.Point(177, 137)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(141, 20)
        Me.score.TabIndex = 20
        Me.score.Text = "Score : ★★★★☆(67)"
        '
        'loueur
        '
        Me.loueur.AutoSize = True
        Me.loueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loueur.Location = New System.Drawing.Point(177, 98)
        Me.loueur.Name = "loueur"
        Me.loueur.Size = New System.Drawing.Size(147, 20)
        Me.loueur.TabIndex = 21
        Me.loueur.Text = "Loueur: Jerry Goller"
        '
        'lieu_annonce
        '
        Me.lieu_annonce.AutoSize = True
        Me.lieu_annonce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lieu_annonce.Location = New System.Drawing.Point(177, 62)
        Me.lieu_annonce.Name = "lieu_annonce"
        Me.lieu_annonce.Size = New System.Drawing.Size(74, 20)
        Me.lieu_annonce.TabIndex = 22
        Me.lieu_annonce.Text = "Toulouse"
        '
        'prix_journalier
        '
        Me.prix_journalier.AutoSize = True
        Me.prix_journalier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix_journalier.Location = New System.Drawing.Point(159, 202)
        Me.prix_journalier.Name = "prix_journalier"
        Me.prix_journalier.Size = New System.Drawing.Size(91, 24)
        Me.prix_journalier.TabIndex = 23
        Me.prix_journalier.Text = "67 €/jours"
        '
        'disponibilités
        '
        Me.disponibilités.AutoSize = True
        Me.disponibilités.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disponibilités.Location = New System.Drawing.Point(6, 286)
        Me.disponibilités.Name = "disponibilités"
        Me.disponibilités.Size = New System.Drawing.Size(110, 20)
        Me.disponibilités.TabIndex = 24
        Me.disponibilités.Text = "Disponibilités :"
        '
        'a_propos
        '
        Me.a_propos.AutoSize = True
        Me.a_propos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_propos.Location = New System.Drawing.Point(6, 251)
        Me.a_propos.Name = "a_propos"
        Me.a_propos.Size = New System.Drawing.Size(190, 24)
        Me.a_propos.TabIndex = 25
        Me.a_propos.Text = "A propos du véhicule"
        '
        'equipements_detail
        '
        Me.equipements_detail.AutoSize = True
        Me.equipements_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equipements_detail.Location = New System.Drawing.Point(6, 520)
        Me.equipements_detail.Name = "equipements_detail"
        Me.equipements_detail.Size = New System.Drawing.Size(324, 20)
        Me.equipements_detail.TabIndex = 26
        Me.equipements_detail.Text = "Equipements : GPS, climatisation, régulateur"
        '
        'transmission_detail
        '
        Me.transmission_detail.AutoSize = True
        Me.transmission_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transmission_detail.Location = New System.Drawing.Point(6, 550)
        Me.transmission_detail.Name = "transmission_detail"
        Me.transmission_detail.Size = New System.Drawing.Size(178, 20)
        Me.transmission_detail.TabIndex = 27
        Me.transmission_detail.Text = "Transmission : manuelle"
        '
        'places_detail
        '
        Me.places_detail.AutoSize = True
        Me.places_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.places_detail.Location = New System.Drawing.Point(6, 577)
        Me.places_detail.Name = "places_detail"
        Me.places_detail.Size = New System.Drawing.Size(158, 20)
        Me.places_detail.TabIndex = 28
        Me.places_detail.Text = "Nombre de places : 4"
        '
        'kilometrage_detail
        '
        Me.kilometrage_detail.AutoSize = True
        Me.kilometrage_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilometrage_detail.Location = New System.Drawing.Point(6, 607)
        Me.kilometrage_detail.Name = "kilometrage_detail"
        Me.kilometrage_detail.Size = New System.Drawing.Size(175, 20)
        Me.kilometrage_detail.TabIndex = 29
        Me.kilometrage_detail.Text = "Kilométrage : 20000 km"
        '
        'distance_detail
        '
        Me.distance_detail.AutoSize = True
        Me.distance_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distance_detail.Location = New System.Drawing.Point(307, 62)
        Me.distance_detail.Name = "distance_detail"
        Me.distance_detail.Size = New System.Drawing.Size(67, 20)
        Me.distance_detail.TabIndex = 30
        Me.distance_detail.Text = "A 50 km"
        '
        'annonce_detail
        '
        Me.annonce_detail.Controls.Add(Me.prix_total_label)
        Me.annonce_detail.Controls.Add(Me.Label3)
        Me.annonce_detail.Controls.Add(Me.PictureBox1)
        Me.annonce_detail.Controls.Add(Me.PictureBox3)
        Me.annonce_detail.Controls.Add(Me.Btn_reserver)
        Me.annonce_detail.Controls.Add(Me.distance_detail)
        Me.annonce_detail.Controls.Add(Me.nom_annonce)
        Me.annonce_detail.Controls.Add(Me.kilometrage_detail)
        Me.annonce_detail.Controls.Add(Me.score)
        Me.annonce_detail.Controls.Add(Me.places_detail)
        Me.annonce_detail.Controls.Add(Me.loueur)
        Me.annonce_detail.Controls.Add(Me.transmission_detail)
        Me.annonce_detail.Controls.Add(Me.lieu_annonce)
        Me.annonce_detail.Controls.Add(Me.equipements_detail)
        Me.annonce_detail.Controls.Add(Me.prix_journalier)
        Me.annonce_detail.Controls.Add(Me.a_propos)
        Me.annonce_detail.Controls.Add(Me.disponibilités)
        Me.annonce_detail.Location = New System.Drawing.Point(555, 15)
        Me.annonce_detail.Name = "annonce_detail"
        Me.annonce_detail.Size = New System.Drawing.Size(390, 666)
        Me.annonce_detail.TabIndex = 33
        Me.annonce_detail.TabStop = False
        Me.annonce_detail.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(307, 591)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "355€"
        '
        'prix_total_label
        '
        Me.prix_total_label.AutoSize = True
        Me.prix_total_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix_total_label.Location = New System.Drawing.Point(252, 567)
        Me.prix_total_label.Name = "prix_total_label"
        Me.prix_total_label.Size = New System.Drawing.Size(61, 24)
        Me.prix_total_label.TabIndex = 34
        Me.prix_total_label.Text = "Total :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Location.My.Resources.Resources.picture_placeholder
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Location.My.Resources.Resources.Capture2
        Me.PictureBox3.Location = New System.Drawing.Point(10, 309)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(199, 179)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'photo_exemple1
        '
        Me.photo_exemple1.BackgroundImage = Global.Location.My.Resources.Resources.picture_placeholder
        Me.photo_exemple1.Location = New System.Drawing.Point(6, 12)
        Me.photo_exemple1.Name = "photo_exemple1"
        Me.photo_exemple1.Size = New System.Drawing.Size(65, 52)
        Me.photo_exemple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photo_exemple1.TabIndex = 14
        Me.photo_exemple1.TabStop = False
        '
        'photo_exemple2
        '
        Me.photo_exemple2.BackgroundImage = Global.Location.My.Resources.Resources.picture_placeholder
        Me.photo_exemple2.Location = New System.Drawing.Point(6, 12)
        Me.photo_exemple2.Name = "photo_exemple2"
        Me.photo_exemple2.Size = New System.Drawing.Size(65, 52)
        Me.photo_exemple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photo_exemple2.TabIndex = 14
        Me.photo_exemple2.TabStop = False
        '
        'Parcours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 693)
        Me.Controls.Add(Me.annonce_detail)
        Me.Controls.Add(Me.filtres)
        Me.Controls.Add(Me.options)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Parcours"
        Me.Text = "Parcours"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.exemple1.ResumeLayout(False)
        Me.exemple1.PerformLayout()
        Me.exemple2.ResumeLayout(False)
        Me.exemple2.PerformLayout()
        Me.options.ResumeLayout(False)
        Me.options.PerformLayout()
        CType(Me.place_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.place_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_distance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.annonce_detail.ResumeLayout(False)
        Me.annonce_detail.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photo_exemple1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photo_exemple2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_reserver As Button
    Friend WithEvents options As GroupBox
    Friend WithEvents nombre_place As Label
    Friend WithEvents Label4_place_min As Label
    Friend WithEvents Label4_place_max As Label
    Friend WithEvents place_max As NumericUpDown
    Friend WithEvents place_min As NumericUpDown
    Friend WithEvents Label_pix_max As Label
    Friend WithEvents Label_prix_min As Label
    Friend WithEvents prix_max As TextBox
    Friend WithEvents prix_min As TextBox
    Friend WithEvents prix As Label
    Friend WithEvents automatique As RadioButton
    Friend WithEvents manuelle As RadioButton
    Friend WithEvents transmission As Label
    Friend WithEvents porte_velos As CheckBox
    Friend WithEvents regulateur As CheckBox
    Friend WithEvents climatisation As CheckBox
    Friend WithEvents gps As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label_distance As Label
    Friend WithEvents distance As Label
    Friend WithEvents TrackBar_distance As TrackBar
    Friend WithEvents caracteristiques As Label
    Friend WithEvents utilitaire As CheckBox
    Friend WithEvents voiture As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents location_multiple As CheckBox
    Friend WithEvents filtres As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nom_annonce As Label
    Friend WithEvents score As Label
    Friend WithEvents loueur As Label
    Friend WithEvents lieu_annonce As Label
    Friend WithEvents prix_journalier As Label
    Friend WithEvents disponibilités As Label
    Friend WithEvents a_propos As Label
    Friend WithEvents equipements_detail As Label
    Friend WithEvents transmission_detail As Label
    Friend WithEvents places_detail As Label
    Friend WithEvents kilometrage_detail As Label
    Friend WithEvents distance_detail As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents annonce_detail As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents loueur2 As Label
    Friend WithEvents photo_exemple2 As PictureBox
    Friend WithEvents exemple1 As GroupBox
    Friend WithEvents photo_exemple1 As PictureBox
    Friend WithEvents ville1 As Label
    Friend WithEvents loueur1 As Label
    Friend WithEvents exemple2 As GroupBox
    Friend WithEvents ville2 As Label
    Friend WithEvents prix_total_label As Label
    Friend WithEvents Label3 As Label
End Class
