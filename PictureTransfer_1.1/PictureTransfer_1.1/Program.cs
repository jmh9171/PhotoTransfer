using System;
using System.IO;

namespace PictureTransfer_1._1
{
   
}

class Program
{
    public static void Transfer2()
    {
        DateTime time = DateTime.Now;
        string now = time.ToString().Replace('/', '-').Replace(' ','_').Replace(':','-');
        string folder = "Pictures";
        string folderName = System.IO.Path.Combine(folder, now);
        string sourcePath2 = @"F:DCIM\100CANON" ;
        string targetPath2 = @"E:\";
        string computerPath = @"C:\Users\Jacob\";
        string[] folders = System.IO.Directory.GetDirectories(sourcePath2);
        string[] files = System.IO.Directory.GetFiles(sourcePath2);
        Console.WriteLine("Folders:");
        Console.WriteLine(now);
        for (int i = 0; i < folders.Length; i++)
        {
            Console.WriteLine(folders[i]);
        }
        string realTargetPath = System.IO.Path.Combine(targetPath2, folderName);
        string computerCopy = Path.Combine(computerPath, folderName);
        if (!(System.IO.Directory.Exists(realTargetPath)))
        {

            System.IO.Directory.CreateDirectory(realTargetPath);
            System.IO.Directory.CreateDirectory(computerCopy);
        }
        Console.WriteLine("\nFiles: Copying Files...");

        

        for (int k = 0; k < files.Length; k++)
        {
            string destFile = System.IO.Path.Combine(realTargetPath, files[k]);
           
        }
        if (System.IO.Directory.Exists(sourcePath2))
        {
            foreach (string s in files)
            {

                // Use static Path methods to extract only the file name from the path.
               string fileName = Path.GetFileName(s);
                FileInfo fileInfo = new FileInfo(s);
                Console.WriteLine("  Size: {0}KB", fileInfo.Length/1024);
                
                string destFile = System.IO.Path.Combine(realTargetPath, fileName);
                string destFile2 = System.IO.Path.Combine(computerCopy, fileName);
                Console.WriteLine(s);
                System.IO.File.Copy(s, destFile, true);
                System.IO.File.Copy(s, destFile2, true);
            }
        }
        else
        {
            Console.WriteLine("Source path does not exist!");
        }
        Console.WriteLine("All Files Copied!!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
    }




    static void Main(string[] args)
    {
        //DriveStuff();
        //Transfer("Test_Transfer!!");
        Transfer2();
        Console.ReadKey(true);

    }

    
}

    

