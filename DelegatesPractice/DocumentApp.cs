namespace DocumentApp
{
    public delegate void OutputDataDel(string filepath, string message);
    public class FileManagement
    {
        public void OutputToFile(string filePath, string message)
        {
            Console.WriteLine($"Output data to printerfilepath: {filePath} message: {message}");
        }
        public void OutputToConsole(string filePath, string message)
        {
            Console.WriteLine($"Output data to consolefilepath: {filePath} message: {message}");
        }
        public void OutputToDrive(string filePath, string message)
        {
            Console.WriteLine($"Output data to drivefilepath: {filePath} message: {message}");
        }

        public static void OutputData(string message)
        {
            FileManagement fm = new FileManagement();

            //Assign fileoutput delegate to output to file
            OutputDataDel fileOutput_Del = new OutputDataDel(fm.OutputToFile);
            // ouput to file
            fileOutput_Del("c:/User/mmavis/source/", "Rental Data....");
            //Re-assign fileoutput Delegate to output to console
            fileOutput_Del = new OutputDataDel(fm.OutputToConsole);
            // output to console
            fileOutput_Del("c:/System", "Console Message. Error 403");

            fileOutput_Del = new OutputDataDel(fm.OutputToDrive);
            fileOutput_Del("d:/Homework/English", "Word Document");

            //Clear and Re-Assign object method to fileoutput delegate 
            fileOutput_Del = fm.OutputToFile;
            //Adding multiple references to 3 different object methods
            fileOutput_Del += fm.OutputToConsole;
            fileOutput_Del += fm.OutputToDrive;

            WriteToAllOutputs(fileOutput_Del, message);

        }

        public static void WriteToAllOutputs(OutputDataDel output, string message)
        {
            output("Filepaths: Console Output, File Output, Drive Output", "message: " + message);
        }
    }
}