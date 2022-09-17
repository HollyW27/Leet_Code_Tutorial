public class Solution 
{
    public string ReformatDate(string date) 
    {
        //Creates new dictionary and assigns months to their numerical value
        Dictionary<string, string> months = new Dictionary<string, string>();
        
        months.Add("Jan","01");
        months.Add("Feb","02");
        months.Add("Mar","03");
        months.Add("Apr","04");
        months.Add("May","05");
        months.Add("Jun","06");
        months.Add("Jul","07");
        months.Add("Aug","08");
        months.Add("Sep","09");
        months.Add("Oct","10");
        months.Add("Nov","11");
        months.Add("Dec","12");
        
        //splits string into array
        string[] format = new string[3];
        format = date.Split(" ");
        
        //Assigns value to month and year
        string month = months[format[1]];
        string year = format[2];
        string day = "";
        
        //Checks if single digit number or two digit number
        if(format[0].Length == 3)
        {
            day += "0";
            day += format[0][0];  
        }
        
        else
        {
        //Assigning value to day and removing lettering
        for(int i = 0; i < 2; i++)
        {
            day += format[0][i];
        }
        }
        //Add line to sort out cases where it is a single digit number
        
        
        
        //Putting it all together
        date = year + "-" + month + "-" + day;
        return date;
    }
}