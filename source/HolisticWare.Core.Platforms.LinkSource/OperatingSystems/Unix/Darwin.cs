using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Platforms.OperatingSystems.Unix
{
	public partial class Darwin : BerkeleySoftwareDistribution
	{
		public bool IsCaseSensitive 
		{
			get; 
			set;
		}

		/*
			 NSString *path = [NSString stringWithCString:argv[1] encoding:NSASCIIStringEncoding];
			  NSURL *filesystem = [NSURL fileURLWithPath:path isDirectory:YES];

			  NSNumber *caseSensitiveFS;
			  BOOL hasCaseSensitiveResource;

			  hasCaseSensitiveResource = [filesystem getResourceValue:&caseSensitiveFS
				forKey:NSURLVolumeSupportsCaseSensitiveNamesKey error:NULL];

			  if (hasCaseSensitiveResource)
			  {
				if ([caseSensitiveFS intValue] == 1)
				{
				  NSLog(@"%s is a case sensitive filesystem", argv[1]);
				}
				else
				{
				  NSLog(@"%s is a case insensitive filesystem", argv[1]);
				}
			  }
			  else
			  {
				NSLog(@"can't query %s for case sensitiveness", argv[1]);
			  }

		 
			use terminal to read the File System Personality:

			diskutil info /
			Look for the fields named below:

			   File System Personality:  Journaled HFS+
			   Type (Bundle):            hfs
			   Name (User Visible):      Mac OS Extended (Journaled)
			If the file system is case sensitive, you will see Case-sensitive 
			Journaled HFS in the first pasted line and Mac OS Extended 
			(Case-sensitive, Journaled) in the third.

		
			case insensitive
				File System Personality:  Journaled HFS+
		  
			case sensitive
				File System Personality:  Case-sensitive Journaled HFS+.
		  
		  
			Testing
				touch abc1
				touch abC1
				ls ab*

			Interpreting Results
				1 file - case insensitive
				2 files - case sensitive		  
		  
		  
		  
		  
		  
		*/

	}
}
