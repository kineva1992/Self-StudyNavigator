using System;
using System.Collections.Generic;
using System.Text;

namespace Self_StudyNavigator
{
  /*
  Здесь был объявлен интерфейс IDrawable, который предоставляет метод для рисования объекта. 
  Этот интерфейс может реализовать, например, класс Image. Классы Image и Circle совсем разные сущности, и они не имеют общего базового класса, 
  но мы можем создать список указателей на интерфейс IDrawable, и работать с такими объектами, как с однотипными (с одинаковым интерфейсом). 
  Этот пример с IDrawable более наглядно отображает то, что нам дают интерфейсы. На практике, IGeometrical стоило бы заменить на абстрактный класс.
  */
    public interface ISwitchable
      {
            //Включение
            public void SwitchOn();
            //Выключение
            public void SwitchOff();
      }
}
