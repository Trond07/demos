using System;
using System.Diagnostics;
using System.Text;

//int sum = 1;
//int[] examMarks = { 6, 5, 4, 3, 2 };

//foreach (int m in examMarks)
//{
//    sum = sum * m;
//}
//Console.WriteLine("Mark: {0}", sum);

//List<int> mylist = new List<int>();
//int num = 100;

//for (int i = 2; i <= num; i++)
//{
//    if (num % i != 0)
//    {
//        mylist.Add(i);
//    }
//}
//Console.WriteLine("done");

StringBuilder sb= new StringBuilder();
{
    for (int i = 1; i <= 10; i++)
    {
        string mystrb1 = "";
        {for (int j = 1; j <= 10; j++)
                string str = (i * j).ToString.PadLeft(20, ' ');
            mystrb1 = mystrb1 + (i * j).ToString() + " ";
}
        sb.Append(mystrb1 + "\n");
    }

}
Console.WriteLine(sb.ToString());





// Add your code here.
