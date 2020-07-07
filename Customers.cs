using System;

public class Customers
	{
		public int kode;
		public string nama;
		public int piutang;

		public virtual int Kode
		{
			get
			{
				return kode;
			}
			set
			{
				this.kode = value;
			}
		}


		public virtual string Nama
		{
			get
			{
				return nama;
			}
			set
			{
				this.nama = value;
			}
		}


		public virtual int Piutang
		{
			get
			{
				return piutang;
			}
			set
			{
				this.piutang = value;
			}
		}


		public void daftarCustomer(int kode, string nama, int piutang)
		{
			this.kode = kode;
			this.nama = nama;
			this.piutang = piutang;
		}

		public override string ToString()
		{
			return "daftarCustomer{" + "kode=" + kode + ", nama=" + nama + ", piutang=" + piutang + '}';
		}

	}
