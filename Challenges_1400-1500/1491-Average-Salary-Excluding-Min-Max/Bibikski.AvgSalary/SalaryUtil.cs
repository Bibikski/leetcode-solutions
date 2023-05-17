namespace Bibikski.AvgSalary;

public class SalaryUtil
{
    public double Average(int[] salary)
    {
        double total = 0;
        //Copy the salary argument into a list
        List<int> salaries = salary.Select(x => x).ToList();
        
        //Order and remove first and last salaries
        salaries = salaries.OrderBy(x=>x).ToList();
        salaries.Remove(salaries[0]);
        salaries.Remove(salaries[^1]);
        
        //Iterate and Add
        for (int i = 0; i < salaries.Count; i++)
            total += salaries[i];
        //Divide for average, and return
        total = total / salaries.Count; 
        return total;
    } 
}