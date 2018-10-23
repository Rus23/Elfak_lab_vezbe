#include "calculatorlogic.h"

CalculatorLogic::CalculatorLogic(QObject *parent) : QObject(parent)
{



}


void CalculatorLogic::doCommand(QString s){
    //jednako
    if(s=="="&&prviOperand!=""&&operacija!=""&&drugiOperand!="")
    {
        if(drugiOperand[drugiOperand.length()-1]=='.')
        {
            drugiOperand.remove(drugiOperand.length()-1,1);
        }
        float a = prviOperand.toFloat();
        float b = drugiOperand.toFloat();
        QString rez = "";
        int q = operacija[0].toLatin1();

        switch (q) {
        case 43:
            rez.setNum(a+b);
            break;
        case 45:
            rez.setNum(a-b);
            break;
        case 42:
            rez.setNum(a*b);
            break;
        case 47:
            rez.setNum(a/b);
            break;
        default:
            break;
        }

        emit resultChanged("");
        emit resultHistoryChanged(prviOperand+operacija+drugiOperand+"="+rez);
        prviOperand=drugiOperand=operacija="";
        return;
    }

    //slucaj koren
    if(s=="√")
    {
        if(prviOperand=="")
            return;
        if(prviOperand!=""&&operacija=="")
        {
            QString rez =""; rez.setNum(sqrt(prviOperand.toFloat()));
            emit resultChanged("");
            emit resultHistoryChanged("√"+prviOperand+"="+rez);
            prviOperand="";
            return;
        }
    }

    //brisanje
    if(s=="C"){
        prviOperand=drugiOperand=operacija="";
        emit resultChanged("");
        return;
    }

    //decimala
    if(s==".")
    {
        if(prviOperand=="")
        {
            prviOperand = "0.";
            emit resultChanged(prviOperand);
            return;
        }
        if(operacija==""&&!prviOperand.contains("."))
        {
            prviOperand+=s;
            emit resultChanged(prviOperand);
            return;
        }
        if(operacija!="")
        {
            if(drugiOperand=="")
            {
                drugiOperand = "0.";
                emit resultChanged(prviOperand+operacija+drugiOperand);
                return;
            }
            if(!drugiOperand.contains("."))
            {
                drugiOperand+=s;
                emit resultChanged(prviOperand+operacija+drugiOperand);
                return;
            }
        }
    }

    //brisanje jednog karaktera
    if(s=="←"){
        QString a= "g";
        if(operacija==""){
            QCharRef pom = a[0];
            QCharRef pom2 = a[0];
            if(prviOperand.length()>=2)
                pom2 = prviOperand[prviOperand.length()-2];
            if(prviOperand.length()>=1)
                pom = prviOperand[prviOperand.length()-1];
            if(pom=='.'&&pom2=='0')
            {
                prviOperand.remove(prviOperand.length()-2,2);
                emit resultChanged(prviOperand);
                return;
            }
            prviOperand.remove(prviOperand.length()-1,1);
            emit resultChanged(prviOperand);
            return;
        }
        if(drugiOperand!=""){
            QCharRef pom = a[0];
            QCharRef pom2 = a[0];
            if(drugiOperand.length()>=2)
                pom2 = drugiOperand[drugiOperand.length()-2];
            if(drugiOperand.length()>=1)
                pom = drugiOperand[drugiOperand.length()-1];
            if(pom=='.'&&pom2=='0')
            {
                drugiOperand.remove(drugiOperand.length()-2,2);
                emit resultChanged(prviOperand+operacija+drugiOperand);
                return;
            }
            drugiOperand.remove(drugiOperand.length()-1,1);
            emit resultChanged(prviOperand+operacija+drugiOperand);
            return;
        }
        if(drugiOperand=="")
            return;
    }

    if((s=="+"||s=="-"||s=="/"||s=="*"||s=="√")&&prviOperand=="")
        return;

    if((s=="+"||s=="-"||s=="/"||s=="*") && prviOperand!=""){
        if(prviOperand[prviOperand.length()-1]=='.')
        {
            prviOperand.remove(prviOperand.length()-1,1);
        }
        operacija=s;
        emit resultChanged(prviOperand+operacija);
        return;
    }

    //plus minus
    if(s=="±")
    {
        if(prviOperand!="" && operacija==""){
            if(((prviOperand[0]!="-")?"+":"-")=="+"){
                prviOperand="-"+prviOperand;
                emit resultChanged(prviOperand);
                return;
            }
            else{

                prviOperand=prviOperand.remove(0,1);
                emit resultChanged(prviOperand);
                return;
            }

        }
        if(drugiOperand!="" && operacija!=""){
            if(((drugiOperand[0]!="-")?"+":"-")=="+"){

                drugiOperand="-"+drugiOperand;
                emit resultChanged(prviOperand+operacija+"("+drugiOperand+")");
                return;
            }

            else{
                drugiOperand=drugiOperand.remove(0,1);
                emit resultChanged(prviOperand+operacija+drugiOperand);
                return;
            }
        }
    }

    if(s=="="&&prviOperand=="")
        return;

    if(operacija==""&&s!="."&&s!="√"&&s!="±"&&s!="="){
        if(s=="0"&&prviOperand.length()==0)
        {
            prviOperand+="0.";
            emit resultChanged(prviOperand);
            return;
        }
        prviOperand+=s;
        emit resultChanged(prviOperand);
        return;
    }
    if(operacija!=""&&s!="."&&s!="√"&&s!="±"&&s!="="){
        if(s=="0"&&drugiOperand.length()==0)
        {
            drugiOperand+="0.";
            emit resultChanged(prviOperand+operacija+drugiOperand);
            return;
        }
        drugiOperand+=s;
        emit resultChanged(prviOperand+operacija+drugiOperand);
        return;
    }





}
