		#region // NewFileSaveDialog //////////////////////////////////////////

		public System.Windows.Forms.SaveFileDialog NewFileSaveDialog( string title, string filename )
		{
			filename = Path.GetFileName( filename );	// strip any folder
			string desktop = Environment.GetFolderPath(
				Environment.SpecialFolder.DesktopDirectory );

			var dialog = new System.Windows.Forms.SaveFileDialog()
			{
				// caller may override any of these
				Title = title,
				InitialDirectory = desktop,
				FileName = filename,
				CheckPathExists = true,
				AddExtension = false,
				Filter = FileFilter,
				FilterIndex = 0,
				DefaultExt = DefaultExtension,
			};

			return dialog;
		}

		public const string FileFilter
			= "Executable Files (*.exe)|*.exe"
			+ "|Executable files (*.com)|*.com"
			+ "|Library files (*.dll)|*.dll"
			+ "|Allfiles (*.*)|*.*"
			;

		public const string DefaultExtension = ".exe";

		#endregion
