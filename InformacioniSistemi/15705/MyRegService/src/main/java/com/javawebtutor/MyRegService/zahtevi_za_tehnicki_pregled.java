package com.javawebtutor.MyRegService;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name ="zahtevi_za_tehnicki_pregled")
public class zahtevi_za_tehnicki_pregled {

	@Id
	@Column(name = "id_zah_za_tp")
	private int id_zah_za_tp;
	
	@Column(name = "id_kor")
	private int id_kor;
	
	@Column(name = "id_voz")
	private int id_voz;
	
	@Column(name = "neispravan_deo")
	private int neispravan_deo;
	
	@Column(name = "vrsta_tp")
	private int vrsta_tp;
	
	@Column(name = "snaga_motora")
	private int snaga_motora;
	
	public zahtevi_za_tehnicki_pregled(){
		
	}
	
	public zahtevi_za_tehnicki_pregled(int id_zah_za_tp, int id_kor, int id_voz, int neispravan_deo, int vrsta_tp,
			int snaga_motora) {
		super();
		this.id_zah_za_tp = id_zah_za_tp;
		this.id_kor = id_kor;
		this.id_voz = id_voz;
		this.neispravan_deo = neispravan_deo;
		this.vrsta_tp = vrsta_tp;
		this.snaga_motora = snaga_motora;
	}

	public int getId_zah_za_tp() {
		return id_zah_za_tp;
	}

	public void setId_zah_za_tp(int id_zah_za_tp) {
		this.id_zah_za_tp = id_zah_za_tp;
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

	public int getNeispravan_deo() {
		return neispravan_deo;
	}

	public void setNeispravan_deo(int neispravan_deo) {
		this.neispravan_deo = neispravan_deo;
	}

	public int getVrsta_tp() {
		return vrsta_tp;
	}

	public void setVrsta_tp(int vrsta_tp) {
		this.vrsta_tp = vrsta_tp;
	}

	public int getSnaga_motora() {
		return snaga_motora;
	}

	public void setSnaga_motora(int snaga_motora) {
		this.snaga_motora = snaga_motora;
	}
	
}
