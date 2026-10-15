using Atelier_1;

var lab = new Labyrinth("""
                        +--+--------+
                        |  /        |
                        |  +--+--+  |
                        |     |k    |
                        +--+  |  +--+
                           |k       |
                        +  +-------/|
                        |           |
                        +-----------+
                        """);
Console.WriteLine($"{lab.Width}x{lab.Height}");   // doit afficher 13x9