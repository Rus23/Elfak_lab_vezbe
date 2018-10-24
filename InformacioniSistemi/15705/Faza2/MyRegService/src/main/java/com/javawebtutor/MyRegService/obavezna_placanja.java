package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name ="obavezna_placanja")
public class obavezna_placanja {

	@Id
	@Column(name = "id_oba_pla")
	private int id_oba_pla;
	
	@Column(name = "id_kor")
	private int id_kor;
	
	@Column(name = "sta")
	private int sta;
	
	@Column(name = "cena")
	private int cena;

	public obavezna_placanja(int id_oba_pla, int id_kor, int sta, int cena) {
		super();
		this.id_oba_pla = id_oba_pla;
		this.id_kor = id_kor;
		this.sta = sta;
		this.cena = cena;
	}
	
	public obavezna_placanja(){
		
	}

	public int getId_oba_pla() {
		return id_oba_pla;
	}

	public void setId_oba_pla(int id_oba_pla) {
		this.id_oba_pla = id_oba_pla;
	}

	public int getId_kor() {
		return id_kor;
	}

	public void setId_kor(int id_kor) {
		this.id_kor = id_kor;
	}

	public int getSta() {
		return sta;
	}

	public void setSta(int sta) {
		this.sta = sta;
	}

	public int getCena() {
		return cena;
	}

	public void setCena(int cena) {
		this.cena = cena;
	}
	
	
}
