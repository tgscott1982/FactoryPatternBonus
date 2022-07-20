using FactoryPatternBonus;





Console.WriteLine("Which database would you like to use: List, SQL, or Mongo?");

string databaseType  = Console.ReadLine();

IDataAccess database = DataAccessFactory.GetDataAccessType(databaseType);

List<Product> product1 = database.LoadData();

database.SaveData();


