using System;

namespace lab04 {

	class Program {

		public static void Ex1() {
		DblOp[] operation = // создание экземпляров делегата
						{
					new DblOp(MathOprt.Mul2),
					new DblOp(MathOprt.Sqr)
			};
			for (int j = 0; j < operation.Length; j++) {
				Console.WriteLine("Результаты операции[{0}]:", j);
				Prc(operation[j], 4.0);
				Prc(operation[j], 9.94);
				Prc(operation[j], 3.143);
			}
			static void Prc(DblOp act, double val) {
				double rslt = act(val);
				Console.WriteLine("Исходное значение {0}, результат  {1}",
						val, rslt);
			}
		}

		static void Main(string[] args) {
			System.Console.WriteLine("---------------Ex1----------------");
			Ex1();
			System.Console.WriteLine("---------------Ex2----------------");
			Class1.Ex2();
			System.Console.WriteLine("---------------Ex3----------------");
			Class2.Ex3();
		}

		class MathOprt {
			public static double Mul2(double val) {
				return val * 2;
			}
			public static double Sqr(double val) {
				return val * val;
			}
		}
		delegate double DblOp(double x);//объявление делегата
	}
}
