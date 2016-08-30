/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 30/08/2016
 * Time: 10:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace PlagiarismChecker
{
	/// <summary>
	/// Description of CheckPlagiarism.
	/// </summary>
	public class CheckPlagiarism
	{
		public CheckPlagiarism()
		{
		}
		
		public string[] getWordGroups(string text, int num) {
			
			string[] tokens = text.Split(' ');
			int numOfGroups = tokens.Length / num;
			
			string[] groups = new string[numOfGroups];
			int curIndex = 0;
			for(int x = 0; x < numOfGroups; x++)
			{
				for(int i = 0; i < num; i++) {
					
					if(i != 0) groups[x] += " " + tokens[curIndex];
					else groups[x] += tokens[curIndex];
					
					curIndex++;
				}
			}
			
			return groups;
		}
		
		public string[] getSentences(string text) {
			
			char[] sep = {'.', ';', '!', '?', ':'};
			string[] sentences = text.Split(sep);
			
			return sentences;
		}
		
		
		public int plagiarized = 0; public int numCorpuses = 0;
		public string[] checkPlagiarism(string[] corpuses, bool isGoogle, bool isBing) {
			
			string[] res = new string[corpuses.Length];
			this.plagiarized = 0;
			this.numCorpuses = corpuses.Length;
			
			int i = 0; 
			foreach(string corpus in corpuses) {
				
				string r = "";
				if(isGoogle) {
					r = this.CheckGoogle(corpus);
					
					if(r == "" && isBing == true) {
						r = this.CheckBing(corpus);
					}
					
					if(r != "") this.plagiarized += 1;
				}
				
				else if(isBing) {
					r = this.CheckBing(corpus);
					
					if(r == "" && isGoogle == true) {
						r = this.CheckGoogle(corpus);
					}
					
					if(r != "") this.plagiarized += 1;
				}
				
				res[i] = r;
				
				i++;
			}
			
			return res;
			
		}
		
		public string CheckGoogle(string corpus) {
			
			NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
			queryString["q"] = corpus;
			
			WebClient client = new WebClient();
			string content = client.DownloadString("https://www.google.com.sg/search?q=%22" + queryString.ToString().Replace("q=", "") + "%22");
			
			if(content.ToLower().Contains("did not match any documents")) return "";
			
			return "https://www.google.com.sg/search?q=%22" + queryString.ToString().Replace("q=", "") + "%22";
		}
		
		public string CheckBing(string corpus) {
			
			NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
			queryString["q"] = corpus;
			
			string content = "";
			if(queryString.ToString() != "q=+%0a%0a")
			{
				WebClient client = new WebClient();
				content = client.DownloadString("http://www.bing.com/search?q=\"" + queryString.ToString().Replace("q=", "") + "\"");
			}
			
			if(content.ToLower().Contains("no results found for")) return "";
			
			return "http://www.bing.com/search?q=\"" + queryString.ToString().Replace("q=", "") + "\"";
		}
	}
}
