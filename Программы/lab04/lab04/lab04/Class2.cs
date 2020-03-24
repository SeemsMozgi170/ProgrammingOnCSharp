using System;
using System.Collections.Generic;
using System.Text;

namespace lab04 {
    class Class2 {
		class ChangeEventArgs : EventArgs {
			string str;
			public string Str {
				get {
					return str;
				}
			}
			int change;
			public int Change {
				get {
					return change;
				}
			}
			public ChangeEventArgs(string str, int change) {
				this.str = str;
				this.change = change;
			}
		}
		class GenEvent  // Генератор событий - издатель
		{
			public delegate void ChangeEventHandler
				(object source, ChangeEventArgs e);

			public event ChangeEventHandler OnChangeHandler;

			public void UpdateEvent(string str, int change) {
				if (change == 0)
					return;
				ChangeEventArgs e =
				new ChangeEventArgs(str, change);

				if (OnChangeHandler != null)
					OnChangeHandler(this, e);
			}

		}

		//Подписчик
		class RecEvent {
			//Обработчик события	
			void OnRecChange(object source, ChangeEventArgs e) {
				int change = e.Change;
				Console.WriteLine("Вес груза '{0}' был {1} на {2} тонны",
					e.Str, change > 0 ? "увеличен" : "уменьшен",
					Math.Abs(e.Change));
			}

			GenEvent gnEvent;
			// в конструкторе класса осуществляется подписка
			public RecEvent(GenEvent gnEvent) {
				this.gnEvent = gnEvent;
				gnEvent.OnChangeHandler +=  //здесь осуществляется подписка
						new GenEvent.ChangeEventHandler(OnRecChange);
			}
		}

		public static void Ex3() {
			GenEvent gnEvent = new GenEvent();
			RecEvent inventoryWatch = new RecEvent(gnEvent);
			gnEvent.UpdateEvent("грузовика", -2);
			gnEvent.UpdateEvent("автопоезда", 4);

		}

	}
}
