// See https://aka.ms/new-console-template for more information

using AppSingleton;
using AppSingleton.Decorator;
using AppSingleton.Factory;
using AppSingleton.Observer;
using AppSingleton.Observer_2;
using System;
using System.ComponentModel;
using AppSingleton.Command;

new Thread(NovaThread).Start();

NovaThread();


Thread.CurrentThread.Name = "Main";

Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
taskA.Start();

Console.WriteLine($"Hello from thread {Thread.CurrentThread.Name}");

taskA.Wait();

var shape = ShapeFactory.GetShape("Circle");

//var singleton = Singleton.Instance;
shape?.Draw();
Console.WriteLine("------------------------------------");
var d = new CheeseDecorator(new BasicNoodle());

Console.WriteLine(d.GetIngredients());
Console.WriteLine(d.GetPrice());

Console.WriteLine("------------------------------------");
var c = new WhiteSauce(new BasicNoodle());

Console.WriteLine(c.GetIngredients());
Console.WriteLine(c.GetPrice());

Console.WriteLine("------------------------------------");

var su = new Subject();

su.Change("estou estando");

var ob = new Observer("Mudei", su);
ob.Update("mudei");

Console.WriteLine("------------------------------------");
#region observer2

var observ1 = new HRSpecialist("jose");
var observ2 = new HRSpecialist("maria");

var prov = new ApplicationsHandler();

observ1.Subscribe(prov);
observ2.Subscribe(prov);
prov.AddApplication(new(1, "pedro"));
prov.AddApplication(new(2, "guilherme"));

observ1.ListApplications();
observ2.ListApplications();

observ1.Unsubscribe();

Console.WriteLine();
Console.WriteLine($"{observ1.Name} unsubscribed");
Console.WriteLine();

prov.AddApplication(new(3, "Sofia"));

observ1.ListApplications();
observ2.ListApplications();

prov.CloseApplications();

Console.WriteLine("------------------------------------");
#endregion

Console.WriteLine("---------CONTROL---------------------");

var ctrl = new RemoteControl(new ChangeChannelCommand(new Television(),10));
ctrl.PressButton();

Console.ReadKey();

static void NovaThread()
{
    var singleton = Singleton.Instance;
}