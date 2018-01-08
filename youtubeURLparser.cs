using System;
using System.Text.RegularExpressions;
					
public class youTubeID
	
{
	
	public static string getID(string youTubeURL){
		Match videoID = Regex.Match(youTubeURL, @"(?<=youtube\.com.*v=|.*youtu\.be/)([a-zA-Z0-9]+)(?:[&\?])");
          string theVideoid = videoID.Groups[1].Value;
        	if(!(videoID.Success))
        	{
			videoID = Regex.Match(youTubeURL, @"(?<=youtube.com.*v=|.*youtu\.be)([a-zA-Z0-9]+)");	
            theVideoid = videoID.Groups[1].Value;
        	}	
	return theVideoid;	
	}
	public void Main() //For testing
	{
        string v1 = "https://www.youtube.com/watch?v=sIlNIVXpIns";
        string v2 = "https://youtu.be/sIlNIVXpIns?t=2s";
        string v3 = "https://www.youtube.com/watch?v=sIlNIVXpIns&list=whatever";
		string v4 = "https://www.watttt.com/watch?v=thisshouldbreak";
	string v = youTubeID.getID(v4);
	Console.WriteLine(v);
	Console.WriteLine("ID");
	}
}
