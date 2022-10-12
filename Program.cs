int matriculaMaior = 0;
double alturaMaior = 0;
int matriculaMenor = 0;
double alturaMenor = 0;
int matricula = 0;
double altura = 0;
for(int c = 0;c < 3;c++){
   Console.WriteLine($"Digite a matricula do {c+1}º aluno: ");
   matricula = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine($"Digite a altura do {c+1}º aluno: ");
   altura = Convert.ToDouble(Console.ReadLine());
   alturaMenor = altura;
   matriculaMenor = matricula;
   if(altura > alturaMaior){
    alturaMaior = altura;
    matriculaMaior = matricula;
   }
   else{
    alturaMenor = altura;
    matriculaMenor = matricula;
   }
}
Console.WriteLine($"A matricula do maior aluno é {matriculaMaior} com altura de {alturaMaior}");
Console.WriteLine($"A matricula do menor aluno é {matriculaMenor} com altura de {alturaMenor}");
