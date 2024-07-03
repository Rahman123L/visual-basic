'
'ListView1
'
Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.Title, Me.Genre, Me.Tahun, Me.Sutradara})
Me.ListView1.HideSelection = False
Me.ListView1.Location = New System.Drawing.Point(27, 100)
Me.ListView1.Name = "ListView1"
Me.ListView1.Size = New System.Drawing.Size(750, 236)
Me.ListView1.TabIndex = 2
Me.ListView1.UseCompatibleStateImageBehavior = False
Me.ListView1.View = System.Windows.Forms.View.Details
'
'No
'
Me.No.Text = "NO"
Me.No.Width = 50
'
'Title
'
Me.Title.Text = "TITLE"
Me.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
Me.Title.Width = 215
'
'Genre
'
Me.Genre.Text = "GENRE"
Me.Genre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
Me.Genre.Width = 125
'
'Tahun
'
Me.Tahun.Text = "TAHUN"
Me.Tahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
Me.Tahun.Width = 117
'
'Sutradara
'
Me.Sutradara.Text = "SUTRADARA"
Me.Sutradara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
Me.Sutradara.Width = 285
