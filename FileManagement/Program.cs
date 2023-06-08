
using System;
using System.IO;
using System.Text;  // UTF8Encoding Class
//READ/WRITE bytes from a source
    //-----------------------------------------------------------
        
        /* FileStream Class -------------------------------------------------
        
        public FileStream(string path, FileMode mode, FileAccess access);
        FileStream filestream = new FileStream(newfile.txt, FileMode.Create, FileAccess.Write);
        
        provides a stream for file operations. It can be used to 
        perform both Synchronous and Asynchronous Read and Write 
        operations. With the help of FileStream Class, we can 
        easily read and write data into files.

        Reads or Writes bytes from/to a physical file whether
        it is a .txt, .exe, .jpg or any other file. FileStream is
        derived from the Stream class.
        */

        /* 
            PATH: 
            relative or absolute path for the file that the current FileStream will Encapsulate
            
            FILE MODE: 
            Specifies how the operating system should open a file.
                - CreateNew
                    Specifies that the operating system should create a new file. This requires 
                    a System.Security.Permissions.FileIOPermissionAccess.Write permission. If 
                    the file already exists, a System.IO.IOException exception is thrown.
                - Create
                    Specifies that the operating system should create a new file like the CreateNew 
                    constant. But in this case, if the file already exists, it will be overwritten 
                    instead of throwing an Exception.
                - Open
                    Specifies that the operating system should open an existing file. The ability 
                    to open the file is dependent on the value specified by the System.IO.FileAccess 
                    Enumeration. A System.IO.FileNotFoundException exception is thrown if the file 
                    does not exist.
                - OpenOrCreate
                    It specifies that the operating system should open a file if it exists; 
                    otherwise, a new file should be created. If the file is opened with FileAccess.Read, 
                    System.Security.Permissions.FileIOPermissionAccess.Read permission is required. If 
                    the file access is FileAccess.Write, System.Security.Permissions.FileIOPermissionAccess.Write 
                    permission is required. If the file is opened with FileAccess.ReadWrite, both 
                    Systems.Security.Permissions.FileIOPermissionAccess.Read and 
                    System.Security.Permissions.FileIOPermissionAccess.Write permissions are required.
                - Truncate
                    Specifies that the operating system should open an existing file. When the file is opened, it 
                    should be truncated so that its size is zero bytes. This requires a 
                    System.Security.Permissions.FileIOPermissionAccess.Write permission. Attempts to read from 
                    a file opened with FileMode.Truncate causes a System.ArgumentException exception.
                - Append
                    opens the file if it exists and then adds the content at the end of the file, or creates a new 
                    file. This requires a System.Security.Permissions.FileIOPermissionAccess.Append permission. 
                    FileMode.Append can be used only in conjunction with FileAccess.Write. Trying to seek a 
                    position before the end of the file throws a System.IO.IOException exception, and any attempt 
                    to read fails and throws a System.NotSupportedException exception.

            FILE ACCESS: 
            How the file can be accessed by the FileStream object. Also determines the values returned by the 
            System.IO.FileStream.CanSeek() is true if the path specifies a disk file.

                - Read
                    Gives read access to the file. Data can be read from the file. Combine with Write for read/write access
                - Write
                    Gives write access to the file. Data can be written to the file. Combine with Read for read/write access
                - ReadWrite
                    Gives read and write access to the file. Data can be written to and read from the file.
        
            FILE SHARE:
            Controls the kind of access other FileStream objects can have to the same file.
        
                - None
                    Declines sharing current file. Any request to open the file (by this process or another process) will
                    fail until the file is closed
                - Read
                    Allows subsequent opening of the file for reading. 
                - Write
                    Allows subsequent opening of the file for writing. 
                - ReadWrite
                    Allows subsequent opening of the file for reading or writing.
                - Delete
                    Allows subsequent deleting of a file
                - Inheritable
                    Makes the file handle inheritable by child processes. Not supported by Win32
        */

        /* MemoryStream Class -------------------------------------------------------
        
        MemoryStream ms = new MemoryStream();

        Reads or Writes bytes that are stored in memory.
        */

        /* BufferedStream Class -------------------------------------------------------
        BufferedStream bs = new BufferedStream(Stream.Null);
        Reads or Writes bytes from other Streams to improve the
        performance of certain I/O operations
        */

    //READERS/WRITERS 
        //  StreamReader sr = new StreamReader();
        /*-------------------------------------------------------
        Healper class for reading characters from a Stream by
        converting bytes into characters using an encoded value. 
        It can be used to read strings (characters) from different
        from different Streams like FileStream, MemoryStream, etc.
        */

        //  StreamWriter sw = new StreamWriter();
        /*--------------------------------------------------------
        Helper class for writing a string to a Stream by converting
        characters into bytes. It can be used to write strings to 
        different Streams such as FileStream, MemoryStream, etc.
        */

        //  BinaryReader br = new BinaryReader();
        /*
        Helper class for reading primitive datatype
        from bytes.
        */

        //  BinaryWriter bw = new BinaryWriter();
        /*
        Helper class for writing primitive datatypes
        in binary
        */

namespace FileManagement;
public class Program{
    public static void Main(){    
        CreateFile("CreatingFile.txt");
        FileStreamAppendToFile("CreatingFile.txt", "Add Message\n");
        FileStreamAppendToFile("CreatingFile.txt", "Second Message\n");
        FileStreamAppendToFile("CreatingSecondFile.txt", "Add Message\n");

        /*
        CreateFile(filename);
        WriteToFile(filename, "First Added Message");
        WriteToFile(filename, "Second Added Message");
        ReadFromFile(filename);
        StreamReaderToStreamWriter("Testfile.txt");
        */

    }

    public static void CreateFile(string filename){
        if(File.Exists(filename)){
            File.Delete(filename);
        }
        FileStream fs = File.Create(filename);
        fs.Close();
    }
    

    public static void FileStreamAppendToFile(string filename, string value){
        if(File.Exists(filename)){
            using(FileStream fs = File.Open(filename, FileMode.Append, FileAccess.Write)){
                AppendToExistingFile(fs, value);
            }
        }else{
            using(FileStream fs = File.Create(filename)){
                AppendToNewFile(fs, value);
            }
        }
    }

    private static void AppendToExistingFile(FileStream fs, string message){
        byte[] b = new UTF8Encoding(true).GetBytes(message);
        fs.Write(b, 0, b.Length);
        fs.Close();
    }
    private static void AppendToNewFile(FileStream fs, string message){
        byte[] b = new UTF8Encoding(true).GetBytes(message);
        fs.Write(b, 0, b.Length);
        fs.Close();
    }
    public static void FileStreamWriting(string filename){
         //FILE STREAM WRITING
         FileStream fs;
         if(File.Exists(filename)){
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            
         }else{
            fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
         }
        byte[] bytedata = Encoding.Default.GetBytes("C# is an object oriented language");
        fs.Write(bytedata, 0, bytedata.Length);
        fs.Close();
    }

    public static void FileStreamReading(){
        //FILE STREAM READING

    }

    public static void WriteToFile(string filename, string message){
        if(File.Exists(filename)){
            using(StreamWriter sw = File.AppendText(filename)){
                DateTime now = DateTime.Now;
                sw.WriteLine(now + " " + message);
            }
        }else{
            using(StreamWriter sw = File.CreateText(filename)){
                DateTime now = DateTime.Now;
                sw.WriteLine(now + " " + message);
            }
        }
    }
    public static void ReadFromFile(string filename){

        if(File.Exists(filename)){
            using(StreamReader sr = File.OpenText(filename)){
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }

    public static void StreamReaderToStreamWriter(string filename){
        if(File.Exists(filename)){
            using(StreamReader sr = File.OpenText(filename)){
                StreamWriter sw = File.CreateText("New File.txt");
                sw.WriteLine(sr.ReadToEnd());
                sw.Close();
            }
        }
    }



}
