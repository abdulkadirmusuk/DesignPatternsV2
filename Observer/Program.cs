using Observer;

var productionSystem = new ProductionSystem();
productionSystem.SystemName = "Database Security";
productionSystem.UsingResources = 10;
productionSystem.Subscribe(new Manager());
productionSystem.Subscribe(new Developer());
productionSystem.Subscribe(new Analyst());

productionSystem.IsSecure = false;


Console.ReadLine();