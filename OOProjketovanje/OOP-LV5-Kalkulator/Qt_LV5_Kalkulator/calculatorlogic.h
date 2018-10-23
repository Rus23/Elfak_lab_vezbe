#ifndef CALCULATORLOGIC_H
#define CALCULATORLOGIC_H

#include <QObject>

class CalculatorLogic : public QObject
{
    Q_OBJECT
public:
    explicit CalculatorLogic(QObject *parent = nullptr);

private:
    QString prviBr;
    QString drugiBr;
    QString rezultat;
    QString operacija;
    QString ceoString;

    double br1;
    double br2;
    double rez;

    int prviBrJeRezultat;

    int prviJeDecimalan;
    int drugiJeDecimalan;

    void smanjiQStringZaBrojKaraktera(QString&,int);
    void osveziAtribute();


public:
    void doCommand(QString);

signals:
    void resultChanged(QString);
    void resultHistoryChanged(QString);

public slots:
};

#endif // CALCULATORLOGIC_H
