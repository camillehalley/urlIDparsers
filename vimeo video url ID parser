using System;
using System.Text.RegularExpressions;
					
public class vimeoID
	
{
	
	public static string getVimeoID(string vimeoURL){
		 Match videoID = Regex.Match(vimeoURL, @"vimeo\.com.*/([0-9]+)(?:[&\?])");
          string theVideoid = videoID.Groups[1].Value;
        	if(!(videoID.Success)){ //handles case where channel is numerical value
				videoID = Regex.Match(vimeoURL, @"vimeo.com/channels/[0-9]+/([0-9]+)");
            	theVideoid = videoID.Groups[1].Value;
        	}
		
			if(!(videoID.Success)){ //handles usual case where id is at end of url
				videoID = Regex.Match(vimeoURL, @"vimeo.com.*/([0-9]+)");	
            	theVideoid = videoID.Groups[1].Value;
        	}
		 	
	return theVideoid;	
	}
	public void Main() //For testing
	{
		string v1 = "http://player.vimeo.com/video/6701902";
		string v2 = "http://player.vimeo.com/video/67019022?title=0&byline=0&portrait=0";
		string v3 = "http://vimeo.com/channels/staffpicks/67019026";
		string v4 = "https://vimeo.com/channels/1341/97904523";
		string v5 = "https://mail.google.com/mail/u/0/#inbox/16003c99dcfd606c"; //shouldn't work
		string v6 = "https://www.watttt.com/watch?v=thisshouldbreak"; //shouldn't work

	string v = vimeoID.getVimeoID(v6);
	Console.WriteLine(v);
	Console.WriteLine("ID");
	}
}
