using Casting_Practice;
//boxing-unboxing

//int a = 5;
//object b = a;

//int a = 6;
//object b = a;
//int c = (int)b;

//implicit explicit


//implicit
//byte num = 50;
//int num2 = num;


//explicit
//int a = 10000;
//byte b =(byte) a;
//Console.WriteLine(b);




Fish fish = new Fish();
Animal animal1  =fish;

//Animal animal2 = new Animal();
//Fish fish1 =(Fish) animal2;

Animal animal3 = new Dog();
Animal animal4 = new Fish();

Animal animal = new(); 
 Dog dog = new Dog();

//object[] datas = { 1, 2, 3, true, "salam" };

//object[] animals = { animal1, animal3, animal4,dog,"name" };
//foreach (var item in animals)
//{

//    Animal data = item as Animal;
//    if (data is not null)
//    {
//        data.Name = "Akula";
//        Console.WriteLine(data.Name);
//    }



////    if (item is Animal a)
////    {
////        a.Name = "Toplan";
////        Console.WriteLine(a.Name);
////    }
//}

//DataList dataList = new DataList();
//dataList[0] = "Hello";
//Console.WriteLine(dataList[0]);

Employee employee1 = new();
employee1.Id = 1;
employee1.Age = 50;

Employee employee2 = new();
employee2.Id = 2;
employee2.Age = 30 ;
Console.WriteLine(employee1>employee2);