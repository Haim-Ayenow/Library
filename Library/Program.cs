using Library;

string[] names = new string[] { "haim", "marcos", "irmias", "hjgg", "Ejfgh", "Efhj", "hjgkj" };

List<string> list = (from name in names
                    where name.StartsWith('E')
                    select name).ToList();

foreach(string name in list)
{
    Console.WriteLine(name);
}

Console.WriteLine("10 random nums between 1-56:");
int[] nums = new int[10];
Random rand = new Random();

for(int i = 0; i < nums.Length; i++)
{
    nums[i] = rand.Next(1,56);
    Console.WriteLine(nums[i]);
}
Console.WriteLine("list of random nums above 20");
List<int> list1 =(from num in nums
                 where num >20
                 select num).ToList(); 

foreach(int num in list1)
{
    Console.WriteLine(num);
}




Random random = new Random();

Book[] books = new Book[]
{
new Book("young life","haim",random.Next(500)),
new Book("what","marcos",random.Next(500)),
new Book("who","haim",random.Next(500)),
new Book("when","haim",random.Next(500)),
new Book("why","natan",random.Next(500)),
new Book("where","nugusy",random.Next(500)),
};

Console.WriteLine("above 200 pages list:");
List<Book> listOfBooks = (from book in books
                         where book.Pages > 200
                         select book).ToList();

foreach(Book book in listOfBooks)
{
    Console.WriteLine(book.Pages);
}

List<Book> list1OfBooks = (from book in books
                          where book.Writer.Length > 4
                          select book).ToList();

Console.WriteLine("list of writer name length above 4:");
foreach(Book book in list1OfBooks)
{
    Console.WriteLine(book.Writer);
}

Console.WriteLine("pages under 150:");
List<Book> list2 = books.ToList();
var under150 = list2.Find(book => book.Pages < 150);

Console.WriteLine(under150.Pages);



List<Book> list3 = (from book in books
                   where book.Name.ToLower().EndsWith('y')
                   select book).ToList();

foreach(Book book in list3)
{
    Console.WriteLine(book.Name);
}


var filteredLNames1 = (from Writer in books
                    group Writer by Writer.Writer);

foreach (var group in filteredLNames1) { 
  
    {
        Console.WriteLine($"books writers by names:{group.Key}");
        foreach (Book Writer in group)
            Console.WriteLine(Writer.Writer);
    }
}



var BooksByNames = (from Writer in books
                       group Writer by Writer.Writer);

foreach (var group in BooksByNames)
{

    {
        Console.WriteLine($"books writers by names:{group.Key}");
        foreach (Book Name in group)
            Console.WriteLine(Name.Name);
    }
}
