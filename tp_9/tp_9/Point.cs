﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_9
{
    /*
        Определить понятие «Точка». Состояние объекта определяется
        следующими полями:
        координата по оси абсцисс (вещественное число);
        координата по оси ординат (вещественное число).
        Базируясь на понятии «Точка», определить понятие
        «Прямоугольник». Прямоугольник определить через точки,
        соответствующие его левому верхнему и правому нижнему
        углам. Сдвинуть правый нижний угол прямоугольника пообеим
        осям на заданное расстояние DELTA и вычислить периметр
        прямоугольника после сдвига угла.
    */
    class Point
    {
        private double x;
        private double y;

        public Point(double _x, double _y)
        {
            this.setX(_x);
            this.setY(_y);
        }

        public Point(Point _p)
        {
            this.setX(_p.getX());
            this.setY(_p.getY());
        }

        public double getX() { return x; }
        public double getY() { return y; }

        public void setX(double _x) { this.x = _x; }
        public void setY(double _y) { this.y = _y; }
    }
}
