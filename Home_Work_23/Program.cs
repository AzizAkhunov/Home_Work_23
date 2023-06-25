
using Home_Work_23;


DirectoryInfo r = new DirectoryInfo(Directory.GetCurrentDirectory());
r.CreateSubdirectory("Files_Txt");


CreateTxtFilesAndWrite.CreateFiles_10();
CreateTxtFilesAndWrite.Writeto10Files();
CreateTxtFilesAndWrite.ReadAllFiles();

