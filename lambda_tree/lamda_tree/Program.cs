﻿using System;
using System.Linq.Expressions;

namespace lambda_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1*2+(x-y)
            // Expression.Multiply == 곱하기
            // Expression.Subtract == 빼기
            // Expression.Add == 더하기
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);

            Expression leftExp = Expression.Multiply(const1, const2); // 1*2

            Expression param1 = Expression.Parameter(typeof(int)); //x를 위한 변수
            Expression param2 = Expression.Parameter(typeof(int)); // y를 위한 변수
            Expression rightExp = Expression.Subtract(param1, param2); // x-y
            Expression exp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>>
                expression = Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(exp, new ParameterExpression[]
                { (ParameterExpression)param1, (ParameterExpression)param2 });
            Func<int, int, int> func = expression.Compile();
            Console.WriteLine("1*2 + ({0}-{1}) = {2}", 7, 8, func(7, 8));
        }*/
            Expression<Func<int, int, int>> expression = (a,b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile(); // 연산해주기

            //x = 7 ,y = 8
            Console.WriteLine("1*2+({0}-{1} = {2}", 7, 8, func(7, 8));

        }
    }
}
