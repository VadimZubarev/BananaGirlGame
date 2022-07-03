using MathLib;

var y1 = new Dictionary<int, double>();
var y2 = new Dictionary<int, double>();
var y3 = new Dictionary<int, double>();
var y4 = new Dictionary<int, double>();
var y5 = new Dictionary<int, double>();
for (int i = 0; i < 100; i++)
{
    y1.Add(i, RespawnFunctions.Parabola(i));
    y2.Add(i, RespawnFunctions.Linear(i));
    y3.Add(i, RespawnFunctions.LinearWaves(i));
    y4.Add(i, RespawnFunctions.GrowingSinusoida(i));
    y5.Add(i, RespawnFunctions.AlcoholicParabola(i));
}
Console.ReadLine();
