
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,1,4,5,6,0,1,0};
        Dictionary<int,int> dict=new Dictionary<int,int>();
        foreach(int i in arr)
        {
        if(dict.ContainsKey(i))
        dict[i]+=1;
        else
        dict.Add(i,1);
        }
        foreach(var kvp in dict)
        {
            Console.WriteLine("ele:{0} , Freq:{1}",kvp.Key,kvp.Value);
        }
    }
}