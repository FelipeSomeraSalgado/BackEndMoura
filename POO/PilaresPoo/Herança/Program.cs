
using Herança;


Carro fusca = new Carro();
Veiculo generic = new Veiculo();

Aviao airBussA320 = new Aviao();
Moto HarleyDavilson = new Moto();
HarleyDavilson.Marca = "HarleyDavilson";
HarleyDavilson.Modelo = "Fat Boy";
HarleyDavilson.Ano = 2028;
HarleyDavilson.SomDaMoto();
HarleyDavilson.Acelerar();

airBussA320.Marca = "LATAM AirBuss";
airBussA320.Modelo = "AirBuss 320";
airBussA320.Ano = 2022;
airBussA320.QtdAsas = 2;
airBussA320.Voar();