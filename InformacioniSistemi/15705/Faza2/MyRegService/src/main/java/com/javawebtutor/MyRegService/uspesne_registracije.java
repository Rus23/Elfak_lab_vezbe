package com.javawebtutor.MyRegService;

import java.sql.Timestamp;
import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

@Entity
@Table(name="usensne_regirstacije")
public class uspesne_registracije {

	@Id
	@Column (name="id_usp_reg")
	private int id_usp_reg;
	
	@Column (name="id_kor")
	private int id_kor;
	
	@Column (name="id_voz")
	private int id_voz;

    @Temporal(TemporalType.TIMESTAMP)
	@Column (name="rok_zavrsetka")
	private Date rok_zavrsetka;

	public uspesne_registracije(int id_usp_reg, int id_kor, int id_voz, Date rok_zavrsetka) {
		super();
		this.id_usp_reg = id_usp_reg;
		this.id_kor = id_kor;
		this.id_voz = id_voz;
		this.rok_zavrsetka = rok_zavrsetka;
	}
	public uspesne_registracije(){
		
	}

	public int getId_usp_reg() {
		return id_usp_reg;
	}

	public void setId_usp_reg(int id_usp_reg) {
		this.id_usp_reg = id_usp_reg;
	}

	public int getId_kor() {
		return id_kor;
	}

	public void setId_kor(int id_kor) {
		this.id_kor = id_kor;
	}

	public int getId_voz() {
		return id_voz;
	}

	public void setId_voz(int id_voz) {
		this.id_voz = id_voz;
	}

	public Date getRok_zavrsetka() {
		return rok_zavrsetka;
	}

	public void setRok_zavrsetka(Date rok_zavrsetka) {
		this.rok_zavrsetka = rok_zavrsetka;
	}
    
    
	
}
