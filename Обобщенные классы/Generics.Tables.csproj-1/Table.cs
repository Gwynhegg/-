using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Tables
{

    public class Table<T1, T2, T3>
    {
        Dictionary<Tuple<T1, T2>, T3> key_values;

        public openTable<T1,T2,T3> Open;
        public ExistedTable<T1, T2, T3> Existed;
        public Rows<T1, T2, T3> Rows;
        public Columns<T1, T2, T3> Columns;

        private List<Rows<T1, T2, T3>> vault_row;
        private List<Columns<T1, T2, T3>> vault_col;





        public Table()
        {
            Rows = new Rows<T1, T2, T3>(this);
            Columns = new Columns<T1, T2, T3>(this);
            vault_row = new List<Rows<T1, T2, T3>>();
            vault_col = new List<Columns<T1, T2, T3>>();
            key_values = new Dictionary<Tuple<T1, T2>, T3>();
            Open = new openTable<T1, T2, T3>(ref key_values, ref vault_row, ref vault_col, this);
            Existed = new ExistedTable<T1, T2, T3>(ref key_values, ref vault_row, ref vault_col, this);
        }
        public void AddRow(T1 row_name)
        {
            Rows<T1, T2, T3> row = new Rows<T1,T2,T3>( this);
            bool temp = false;
            row.Name = row_name;
            foreach (Rows<T1, T2, T3> e in vault_row) if (e.Name.ToString() == row.Name.ToString()) temp = true;
            if (!temp) vault_row.Add(row);

        }

        public void AddColumn(T2 column_name)
        {
            Columns<T1, T2, T3> col = new Columns<T1, T2, T3>(this);
            bool temp = false;
            col.Name = column_name;
            foreach (Columns<T1, T2, T3> e in vault_col) if (e.Name.ToString() == col.Name.ToString()) temp = true;
            if (!temp) vault_col.Add(col);
        }

        public int getRowsCount()
        {
            return vault_row.Count;
        }

        public int getColsCount()
        {
            return vault_col.Count;
        }


    }

    public class Rows<T1,T2,T3> 
    {
        Table<T1, T2, T3> backtrack;
        private T1 name;
        public T1 Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Count()
        {
            return backtrack.getRowsCount();
        }
        public Rows(Table<T1, T2, T3> backtrack)
        {
            this.backtrack = backtrack;
        }

        public Rows(T1 value)
        {
            this.name = value;
        }

    }


    public class Columns<T1, T2, T3> 
    {
        Table<T1, T2, T3> backtrack;

        private T2 name;
        public T2 Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Count()
        {
            return backtrack.getColsCount();
        }
        public Columns(Table<T1, T2, T3> backtrack)
        {
            this.backtrack = backtrack;
        }

        public Columns(T2 value)
        {
            this.name = value;
        }

    }

    public class openTable<T1,T2,T3>
    {
        Table<T1, T2, T3> backtrack;
        List<Rows<T1, T2, T3>> rows; List<Columns<T1, T2, T3>> cols;
        Dictionary<Tuple<T1, T2>, T3> key_values;

        public T3 this[T1 first, T2 second]
        {
            get
            {
                try
                {
                    if (key_values.Count == 0) return default(T3);
                    if (key_values[(first, second).ToTuple<T1, T2>()] == null) return default(T3);
                    return key_values[(first, second).ToTuple<T1, T2>()];

                }
                catch
                {
                    throw new ArgumentException();
                }
            }
            set
            {
                try
                {

                        bool first_ok = false, second_ok = false;
                        foreach (Rows<T1, T2, T3> e in rows) if (e.Name.ToString() == first.ToString()) first_ok = true;
                        foreach (Columns<T1, T2, T3> e in cols) if (e.Name.ToString() == second.ToString()) second_ok = true;
                    if (!first_ok) { var temp = new Rows<T1, T2, T3>(first); rows.Add(temp); }
                    if (!second_ok) { var temp = new Columns<T1, T2, T3>(second); cols.Add(temp); }
                    
                    key_values[(first, second).ToTuple<T1, T2>()] = value;

                }
                catch
                {
                    throw new ArgumentException();
                }
            }
        }

        public openTable(ref Dictionary<Tuple<T1, T2>, T3>  table, ref List<Rows<T1, T2, T3>> rows,ref  List<Columns<T1, T2, T3>> cols, Table<T1,T2,T3> backtrack)
        {
            this.rows = rows;
            this.cols = cols;
            key_values = table;
            this.backtrack = backtrack;
        }

    }

    public class ExistedTable<T1, T2, T3>
    {
        List<Rows<T1, T2, T3>> rows; List<Columns<T1, T2, T3>> cols;
        Dictionary<Tuple<T1, T2>, T3> key_values;

        private bool checkCollisions(T1 first, T2 second)
        {
            bool first_ok=false, second_ok=false;
            foreach (Rows<T1, T2, T3> e in rows) if (e.Name.ToString() == first.ToString()) first_ok = true;
            foreach (Columns<T1, T2, T3> e in cols) if (e.Name.ToString() == second.ToString()) second_ok = true;
            if (first_ok && second_ok) return true; else return false;
        }
        public T3 this[T1 first, T2 second]
        {
            get
            {
                try
                {
                    if (checkCollisions(first, second))
                    {
                        if (key_values.Count == 0) return default(T3);
                        if (key_values[(first, second).ToTuple<T1, T2>()] == null) return default(T3); else return key_values[(first, second).ToTuple<T1, T2>()];
                    }
                    else throw new ArgumentException();
                }
                catch
                {
                    throw new ArgumentException();
                }
            }
            set
            {
                try
                {
                    if (checkCollisions(first, second)) key_values[(first, second).ToTuple<T1, T2>()] = value; else throw new ArgumentException();

                }
                catch
                {
                    throw new ArgumentException();
                }
            }
        }

        public ExistedTable(ref Dictionary<Tuple<T1, T2>, T3> table, ref List<Rows<T1, T2, T3>> rows, ref List<Columns<T1, T2, T3>> cols, Table<T1, T2, T3> backtrack)
        {
            this.rows = rows;
            this.cols = cols;
            key_values = table;
        }

    }
}
