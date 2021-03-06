/** 
* Copyright (c) 2007, Ritu Jain, Chinmay Nagarkar and Sahi Technologies Pvt Ltd
* All rights reserved.
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*     * Redistributions of source code must retain the above copyright
*       notice, this list of conditions and the following disclaimer.
*     * Redistributions in binary form must reproduce the above copyright
*       notice, this list of conditions and the following disclaimer in the
*       documentation and/or other materials provided with the distribution.
*     * Neither the name of the Sahi Technologies Pvt. Ltd./Esahi.com  nor the
*       names of its contributors may be used to endorse or promote products
*       derived from this software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE REGENTS AND CONTRIBUTORS ``AS IS'' AND ANY
* EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
* WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
* DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR ANY
* DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
* (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
* LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
* ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
* (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
* SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using System;
using BaseEvaluator = org.drools.@base.BaseEvaluator;
using Evaluator = org.drools.spi.Evaluator;
namespace org.drools.dotnet.evaluator
{
	
	public class DoubleFactory
	{
		
		public static Evaluator getDoubleEvaluator(int operator_Renamed)
		{
			switch (operator_Renamed)
			{
				
				case Evaluator.__Fields.EQUAL: 
					return DoubleEqualEvaluator.INSTANCE;
				
				case Evaluator.__Fields.NOT_EQUAL: 
					return DoubleNotEqualEvaluator.INSTANCE;
				
				case Evaluator.__Fields.LESS: 
					return DoubleLessEvaluator.INSTANCE;
				
				case Evaluator.__Fields.LESS_OR_EQUAL: 
					return DoubleLessOrEqualEvaluator.INSTANCE;
				
				case Evaluator.__Fields.GREATER: 
					return DoubleGreaterEvaluator.INSTANCE;
				
				case Evaluator.__Fields.GREATER_OR_EQUAL: 
					return DoubleGreaterOrEqualEvaluator.INSTANCE;
				
				default: 
					throw new System.SystemException("Operator '" + operator_Renamed + "' does not exist for DoubleEvaluator");
				
			}
		}
		
		internal class DoubleEqualEvaluator:BaseEvaluator
		{
			private const long serialVersionUID = 8638265291388692160L;
			public static readonly Evaluator INSTANCE = new DoubleEqualEvaluator();
			
			internal DoubleEqualEvaluator():base(Evaluator.__Fields.DOUBLE_TYPE, Evaluator.__Fields.EQUAL)
			{
			}
			
			public override bool evaluate(System.Object object1, System.Object object2)
			{
				if (object1 == null)
				{
					return object2 == null;
				}
				return ((System.ValueType) object1).Equals(object2);
			}
			
			public virtual System.String toString()
			{
				return "Double ==";
			}
		}
		
		internal class DoubleNotEqualEvaluator:BaseEvaluator
		{
			private const long serialVersionUID = - 1605810860861480665L;
			public static readonly Evaluator INSTANCE = new DoubleNotEqualEvaluator();
			
			internal DoubleNotEqualEvaluator():base(Evaluator.__Fields.DOUBLE_TYPE, Evaluator.__Fields.NOT_EQUAL)
			{
			}
			
			public override bool evaluate(System.Object object1, System.Object object2)
			{
				if (object1 == null)
				{
					return object2 != null;
				}
				return !((System.ValueType) object1).Equals(object2);
			}
			
			public virtual System.String toString()
			{
				return "Double !=";
			}
		}
		
		internal class DoubleLessEvaluator:BaseEvaluator
		{
			private const long serialVersionUID = - 6256590818217451743L;
			public static readonly Evaluator INSTANCE = new DoubleLessEvaluator();
			
			internal DoubleLessEvaluator():base(Evaluator.__Fields.DOUBLE_TYPE, Evaluator.__Fields.LESS)
			{
			}
			
			public override bool evaluate(System.Object object1, System.Object object2)
			{
				return System.Convert.ToDouble(((System.ValueType) object1)) < System.Convert.ToDouble(((System.ValueType) object2));
			}
			
			public virtual System.String toString()
			{
				return "Double <";
			}
		}
		
		internal class DoubleLessOrEqualEvaluator:BaseEvaluator
		{
			private const long serialVersionUID = - 3663317930533546094L;
			public static readonly Evaluator INSTANCE = new DoubleLessOrEqualEvaluator();
			
			internal DoubleLessOrEqualEvaluator():base(Evaluator.__Fields.DOUBLE_TYPE, Evaluator.__Fields.LESS_OR_EQUAL)
			{
			}
			
			public override bool evaluate(System.Object object1, System.Object object2)
			{
				return System.Convert.ToDouble(((System.ValueType) object1)) <= System.Convert.ToDouble(((System.ValueType) object2));
			}
			
			public virtual System.String toString()
			{
				return "Double <=";
			}
		}
		
		internal class DoubleGreaterEvaluator:BaseEvaluator
		{
			private const long serialVersionUID = 1420842292058943594L;
			public static readonly Evaluator INSTANCE = new DoubleGreaterEvaluator();
			
			internal DoubleGreaterEvaluator():base(Evaluator.__Fields.DOUBLE_TYPE, Evaluator.__Fields.GREATER)
			{
			}
			
			public override bool evaluate(System.Object object1, System.Object object2)
			{
				return System.Convert.ToDouble(((System.ValueType) object1)) > System.Convert.ToDouble(((System.ValueType) object2));
			}
			
			public virtual System.String toString()
			{
				return "Double >";
			}
		}
		
		internal class DoubleGreaterOrEqualEvaluator:BaseEvaluator
		{
			private const long serialVersionUID = 468558955316190757L;
			public static readonly Evaluator INSTANCE = new DoubleGreaterOrEqualEvaluator();
			
			internal DoubleGreaterOrEqualEvaluator():base(Evaluator.__Fields.DOUBLE_TYPE, Evaluator.__Fields.GREATER_OR_EQUAL)
			{
			}
			
			public override bool evaluate(System.Object object1, System.Object object2)
			{
				return System.Convert.ToDouble(((System.ValueType) object1)) >= System.Convert.ToDouble(((System.ValueType) object2));
			}
			
			public virtual System.String toString()
			{
				return "Double >=";
			}
		}
	}
}