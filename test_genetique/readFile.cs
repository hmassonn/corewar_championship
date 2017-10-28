//new champion = champion

int width = 0;
string line;

string path = @"c:\champstest\Asombra.s";

// Read the file and display it line by line.
//System.IO.StreamReader file = new System.IO.StreamReader(@"c:\test.txt");
System.IO.StreamReader file = new System.IO.StreamReader(@path);
while((line = file.ReadLine()) != null)
{
    // If it's a comment line then go to the next one
    if(line[0] == '.')
      continue

    // clean the line
    line = line.Replace("\t", "");

    // Separate the instruction from the parameters
    string instruction = line.Substring(0, line.indexOf(' '));
    string str_param = line.Substring(line.indexOf(' '), line.Length());

    // Separate each param
    string[] parameters = str_param.Split(', ');
    foreach(parameters as parameter){
      
    }
    width++;
}

file.Close();
System.Console.WriteLine("There were {0} lines.", width);
// Suspend the screen.
System.Console.ReadLine();
