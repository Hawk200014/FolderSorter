using System;
using System.IO;


namespace FolderSorter
{
    internal class FolderManager
	{
		private string programmFolder = Environment.CurrentDirectory;
		private string sortDataFolderName = "SortData";
		private string destinationDataFolderName = "DestinationData";

		public FolderManager()
		{

		}

		public void CreateFolders()
		{
			CreateDestinationFolderData();
			CreateSortDataFolder();
		}

		private void CreateSortDataFolder()
		{
			Directory.CreateDirectory(System.IO.Path.Combine(programmFolder, sortDataFolderName));
		}

		private void CreateDestinationFolderData()
		{
			Directory.CreateDirectory(System.IO.Path.Combine(programmFolder, destinationDataFolderName));
		}

		public string GetSortDataPath()
		{
			return System.IO.Path.Combine(programmFolder, sortDataFolderName);
		}

		public string GetDestinationDataPath()
		{
			return System.IO.Path.Combine(programmFolder, destinationDataFolderName);
		}

	}
}