#include "calculatorlogic.h"
#include <string.h>
#include <QString>
#include <qmath.h>
#include <QtMath>
#include <QMessageBox>
#include <math.h>

CalculatorLogic::CalculatorLogic(QObject *parent) : QObject(parent)
{
    this->prviBrJeRezultat = -23;

    this->prviJeDecimalan = -13;
    this->drugiJeDecimalan = -13;
}
void CalculatorLogic::osveziAtribute()
{
    this->prviBrJeRezultat *= (this->prviBrJeRezultat < 0)? -1:1;

    this->drugiBr.clear();
    this->operacija.clear();
    this->rezultat.clear();
    this->ceoString.replace(this->ceoString,this->prviBr);

    this->br2=0;
    this->rez=0;
}
void CalculatorLogic::smanjiQStringZaBrojKaraktera(QString& string, int br)
{
    QString pom;
    for(int i=0;i<string.length()-br;i++)
    {
        pom[i] = string[i];
    }
    string.replace(string,pom);

}
//Samoo emitii da se sredee i slotovii dinamickii :DD Celaa radii
void CalculatorLogic::doCommand(QString string) // Zakasnela ideja da prviBr bude rezultat ??
{

    if( (string[0] >= '0' && string[0]<='9') || (string.compare(".")) == 0) // da li je Broj
    {
        if((this->operacija.compare("")) == 0)
        {
            if(prviBrJeRezultat > 0 && (QString::compare(string,".") != 0))
            {
                this->prviBr.replace(this->prviBr,string);
                this->ceoString.replace(this->ceoString,string);

                this->prviBrJeRezultat *= -1;
            }
            else
            {                
                if(QString::compare(string,".") == 0)
                {
                    if(QString::compare(this->prviBr,"")!=0 && this->prviJeDecimalan < 0)
                    {
                        this->prviJeDecimalan *= -1;
                    }
                    else
                        return;
                }
                this->prviBr.append(string);
                this->ceoString.append(string);

                this->prviBrJeRezultat *= (this->prviBrJeRezultat > 0)?-1:1;
            }
            br1 = this->prviBr.toDouble();

            emit this->resultChanged(this->prviBr);
        }
        else
        {
            if(QString::compare(string,".") == 0)
            {
                if(QString::compare(this->drugiBr,"")!=0 && this->drugiJeDecimalan < 0)
                {
                    this->drugiJeDecimalan *= -1;
                }
                else
                    return;
            }
            this->drugiBr.append(string);
            br2 = this->drugiBr.toDouble();

            this->ceoString.append(string);

            emit this->resultChanged(this->drugiBr);
        }

        //emit this->resultChanged(this->ceoString);
    }
    else if((QString::compare(string,"=")) == 0) // da li je je JEDNAKO =
    {
        if((QString::compare(this->operacija,"+"))== 0)
        {
            br1 = br1+br2;
        }
        else if((QString::compare(this->operacija,"-"))== 0)
        {
            br1 = br1-br2;
        }
        else if((QString::compare(this->operacija,"*"))== 0)
        {
            br1 = br1*br2;
        }
        else if((QString::compare(this->operacija,"/"))== 0)
        {
            br1 = br1/br2;
        }

        this->prviBr = QString::number(br1);

        this->ceoString.append(string);
        this->ceoString.append(this->prviBr);

        emit this->resultChanged(this->prviBr); // ili prviBr
        emit this->resultHistoryChanged(this->ceoString);
        this->osveziAtribute();
    }
    else // SAMOO OPERACIJAAA
    {
        if((QString::compare(string,"sin")) == 0)
        {
            if((QString::compare(this->drugiBr,""))!= 0)
            {
                br2 = sin(br2);

                QString pom;
                pom.append(string);
                pom.append(this->drugiBr);
                pom.append("=");
                pom.append(QString::number(br2));

                this->smanjiQStringZaBrojKaraktera(this->ceoString,this->drugiBr.length());
                this->drugiBr.replace(this->drugiBr,QString::number(br2));

                this->ceoString.append(this->drugiBr);

                emit this->resultChanged(this->drugiBr);
                //emit this->resultChanged(this->ceoString);
                emit this->resultHistoryChanged(pom);
            }
            else if((QString::compare(this->prviBr,""))!= 0)
            {
                br1 = sin(br1);

                this->rezultat.replace(this->rezultat,QString::number(br1));
                this->ceoString.replace(this->ceoString,string); // prvo sqrt
                this->ceoString.append(this->prviBr); // pa onda BR
                this->ceoString.append("="); // pa =
                this->ceoString.append(this->rezultat); // i rezultat da bi bilo => sqrt64=8

                this->prviBr.replace(this->prviBr,QString::number(br1));


                emit this->resultChanged(this->prviBr);
                emit this->resultHistoryChanged(this->ceoString);
                this->osveziAtribute();
            }
        }
        else if((QString::compare(string,"cos")) == 0)
        {
            if((QString::compare(this->drugiBr,""))!= 0)
            {
                br2 = cos(br2);

                QString pom;
                pom.append(string);
                pom.append(this->drugiBr);
                pom.append("=");
                pom.append(QString::number(br2));

                this->smanjiQStringZaBrojKaraktera(this->ceoString,this->drugiBr.length());
                this->drugiBr.replace(this->drugiBr,QString::number(br2));

                this->ceoString.append(this->drugiBr);

                emit this->resultChanged(this->ceoString);
                emit this->resultHistoryChanged(pom);
            }
            else if((QString::compare(this->operacija,""))!= 0)
                return;
            else if((QString::compare(this->prviBr,""))!= 0)
            {
                br1 = cos(br1);

                this->rezultat.replace(this->rezultat,QString::number(br1));
                this->ceoString.replace(this->ceoString,string); // prvo sqrt
                this->ceoString.append(this->prviBr); // pa onda BR
                this->ceoString.append("="); // pa =
                this->ceoString.append(this->rezultat); // i rezultat da bi bilo => sqrt64=8

                this->prviBr.replace(this->prviBr,QString::number(br1));


                emit this->resultChanged(this->prviBr);
                emit this->resultHistoryChanged(this->ceoString);
                this->osveziAtribute();
            }
        }
        else if((QString::compare(string,"tan")) == 0)
        {
            if((QString::compare(this->drugiBr,""))!= 0)
            {
                br2 = tan(br2);

                QString pom;
                pom.append(string);
                pom.append(this->drugiBr);
                pom.append("=");
                pom.append(QString::number(br2));

                this->smanjiQStringZaBrojKaraktera(this->ceoString,this->drugiBr.length());
                this->drugiBr.replace(this->drugiBr,QString::number(br2));

                this->ceoString.append(this->drugiBr);

                emit this->resultChanged(this->ceoString);
                emit this->resultHistoryChanged(pom);
            }
            else if((QString::compare(this->operacija,""))!= 0)
                return;
            else if((QString::compare(this->prviBr,""))!= 0)
            {
                br1 = tan(br1);
                this->rezultat.replace(this->rezultat,QString::number(br1));
                this->ceoString.replace(this->ceoString,string); // prvo sqrt
                this->ceoString.append(this->prviBr); // pa onda BR
                this->ceoString.append("="); // pa =
                this->ceoString.append(this->rezultat); // i rezultat da bi bilo => sqrt64=8

                this->prviBr.replace(this->prviBr,QString::number(br1));


                emit this->resultChanged(this->prviBr);
                emit this->resultHistoryChanged(this->ceoString);
                this->osveziAtribute();
            }
        }
        else if((QString::compare(string,"ctan")) == 0)
        {
            if((QString::compare(this->drugiBr,""))!= 0)
            {
                br2 = 1/tan(br2);

                QString pom;
                pom.append(string);
                pom.append(this->drugiBr);
                pom.append("=");
                pom.append(QString::number(br2));

                this->smanjiQStringZaBrojKaraktera(this->ceoString,this->drugiBr.length());
                this->drugiBr.replace(this->drugiBr,QString::number(br2));

                this->ceoString.append(this->drugiBr);

                emit this->resultChanged(this->ceoString);
                emit this->resultHistoryChanged(pom);
            }
            else if((QString::compare(this->operacija,""))!= 0)
                return;
            else if((QString::compare(this->prviBr,""))!= 0)
            {
                br1 = 1/tan(br1);
                this->rezultat.replace(this->rezultat,QString::number(br1));
                this->ceoString.replace(this->ceoString,string); // prvo sqrt
                this->ceoString.append(this->prviBr); // pa onda BR
                this->ceoString.append("="); // pa =
                this->ceoString.append(this->rezultat); // i rezultat da bi bilo => sqrt64=8

                this->prviBr.replace(this->prviBr,QString::number(br1));


                emit this->resultChanged(this->prviBr);
                emit this->resultHistoryChanged(this->ceoString);
                this->osveziAtribute();
            }
        }
        if((QString::compare(string,"C")) == 0) // Maloo viseee
        {
            this->operacija.replace(this->operacija,"");
            this->prviBr.replace(this->prviBr,"");
            this->drugiBr.replace(this->drugiBr,"");
            this->ceoString.replace(this->ceoString,"");

            emit this->resultChanged("");
            emit this->resultHistoryChanged(string);

            this->osveziAtribute();
        }
        else if((QString::compare(string,"<-")) == 0)
        {
           if((QString::compare(this->drugiBr,""))!= 0)
           {
               if(this->drugiBr[this->drugiBr.length() -1] == '.')
               {
                   this->drugiJeDecimalan *= -1;
               }
              smanjiQStringZaBrojKaraktera(this->drugiBr,1);
              smanjiQStringZaBrojKaraktera(this->ceoString,1);
              this->br2 = this->drugiBr.toDouble();

              emit resultChanged(this->ceoString);
           }
           else if((QString::compare(this->operacija,""))!= 0)
           {
               smanjiQStringZaBrojKaraktera(this->operacija,1);
               smanjiQStringZaBrojKaraktera(this->ceoString,1);

               emit resultChanged(this->ceoString);
           }
           else // znaci da postojji samo prvi broj
           {
               if(this->prviBr[this->prviBr.length() -1] == ".")
               {
                   this->prviJeDecimalan *= -1;
               }

              smanjiQStringZaBrojKaraktera(this->prviBr,1);
              smanjiQStringZaBrojKaraktera(this->ceoString,1);
              this->br1 = this->prviBr.toDouble();

              emit resultChanged(this->ceoString);
           }
        }
        else if((QString::compare(string,"+\n-"))== 0)
        {
            if((QString::compare(this->drugiBr,""))!= 0)
            {
                br2 *= -1;

                smanjiQStringZaBrojKaraktera(this->ceoString,this->drugiBr.length());
                this->drugiBr.replace(this->drugiBr,QString::number(br2));
                this->ceoString.append(this->drugiBr);

                emit this->resultChanged(this->ceoString);
            }
            else if((QString::compare(this->prviBr,""))!= 0)
            {
                br1 *=-1;

                smanjiQStringZaBrojKaraktera(this->ceoString,this->prviBr.length());
                this->prviBr.replace(this->prviBr,QString::number(br1));
                this->ceoString.append(this->prviBr);

                emit this->resultChanged(this->ceoString);
            }
        }
        else if((QString::compare(string,"sqrt"))== 0) // Ako se usvoji ideja i ovde treba izmena
        {
            if((QString::compare(this->drugiBr,""))!= 0)
            {
                if(br2<0)
                    return;
                br2 = sqrt(br2);

                QString pom;
                pom.append(string);
                pom.append(this->drugiBr);
                pom.append("=");
                pom.append(QString::number(br2));

                this->smanjiQStringZaBrojKaraktera(this->ceoString,this->drugiBr.length());
                this->drugiBr.replace(this->drugiBr,QString::number(br2));

                this->ceoString.append(this->drugiBr);

                emit this->resultChanged(this->ceoString);
                emit this->resultHistoryChanged(pom);
            }
            else if((QString::compare(this->operacija,""))!= 0)
                return;
            else if((QString::compare(this->prviBr,""))!= 0)
            {
                if(br1<0)
                    return;
                br1 = sqrt(br1);
                this->rezultat.replace(this->rezultat,QString::number(br1));
                this->ceoString.replace(this->ceoString,string); // prvo sqrt
                this->ceoString.append(this->prviBr); // pa onda BR
                this->ceoString.append("="); // pa =
                this->ceoString.append(this->rezultat); // i rezultat da bi bilo => sqrt64=8

                this->prviBr.replace(this->prviBr,QString::number(br1));


                emit this->resultChanged(this->prviBr);
                emit this->resultHistoryChanged(this->ceoString);
                this->osveziAtribute();
            }


        }
        if((QString::compare(this->operacija,"")) != 0)
            return;
        if((QString::compare(string,"+"))== 0)
        {
            this->operacija.replace(this->operacija,string);
            this->ceoString.append(string);

            //emit this->resultChanged(this->ceoString);
            emit this->resultChanged(this->prviBr);
        }
        else if((QString::compare(string,"-"))== 0)
        {
            this->operacija.replace(this->operacija,string);
            this->ceoString.append(string);

            //emit this->resultChanged(this->ceoString);
            emit this->resultChanged(this->prviBr);
        }
        else if((QString::compare(string,"*"))== 0)
        {
            this->operacija.replace(this->operacija,string);
            this->ceoString.append(string);

            //emit this->resultChanged(this->ceoString);
            emit this->resultChanged(this->prviBr);
        }
        else if((QString::compare(string,"/")) == 0)
        {
            this->operacija.replace(this->operacija,string);
            this->ceoString.append(string);

           // emit this->resultChanged(this->ceoString);
           emit this->resultChanged(this->prviBr);
        }

    }
}





