using System;
using System.Globalization;

namespace Transportes_LAR.Proceso
{
	public class Semana
	{
		static Calendar cal = new GregorianCalendar();
		
		public Semana()
		{
		}
		 
		 public String SemanaAno(DateTime date)
		 {
		 	  String valor = "";
		 	 
		 	  DayOfWeek firstDay = DayOfWeek.Monday;
		      CalendarWeekRule rule;
		      rule = CalendarWeekRule.FirstDay;
		      valor = cal.GetWeekOfYear(date, rule, firstDay).ToString();
		      
		      return valor;
		 }
	}
}
