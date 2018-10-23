#include "widget.h"
#include "ui_widget.h"
#include <QMessageBox>
#include <QPushButton>


Widget::Widget(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Widget),
    kalkulator(new CalculatorLogic)
{
    ui->setupUi(this);

    setAllBtnExpanding();
    poveziBtnSaSlotovima();

    connect(kalkulator,SIGNAL(resultChanged(QString)),this,SLOT(onResultChanged(QString)));
    connect(kalkulator,SIGNAL(resultHistoryChanged(QString)),this,SLOT(onResultHistoryChanged(QString)));

    ui->leRezultat->setSizePolicy(QSizePolicy::Expanding,QSizePolicy::Fixed);
    ui->pteIstrojaRezultata->setSizePolicy(QSizePolicy::Expanding,QSizePolicy::Expanding);
}

Widget::~Widget()
{
    delete ui;
}
void Widget::onBtnClicked()
{
     QString pom;
     QPushButton* btnPom = qobject_cast<QPushButton*>(sender());

     kalkulator->doCommand(btnPom->text());
}
void Widget::onResultChanged(QString string)
{
    ui->leRezultat->clear();
    ui->leRezultat->insert(string);
}
void Widget::onResultHistoryChanged(QString string)
{
    ui->pteIstrojaRezultata->appendHtml(string);
}
void Widget::setAllBtnExpanding()
{
    ui->btnBrisiKarakter->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnBrisiRed->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnCetiri->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnDevet->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnDva->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnJedan->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnJednako->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnMinus->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnNula->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnOsam->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnPet->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnPlus->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnPlusMinus->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnPodeljeno->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnPuta->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnSedam->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnSest->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnSqrt->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnTacka->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
    ui->btnTri->setSizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);

}
void Widget::poveziBtnSaSlotovima()
{
    connect(ui->btnBrisiKarakter,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnBrisiRed,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnCetiri,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnDevet,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnDva,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnJedan,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnJednako,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnMinus,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnNula,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnOsam,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnPet,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnPodeljeno,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnPuta,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnSedam,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnSest,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnSqrt,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnTacka,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnTri,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnPlusMinus,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnPlus,SIGNAL(clicked()),this,SLOT(onBtnClicked()));


    connect(ui->btnSin,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnCos,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnTan,SIGNAL(clicked()),this,SLOT(onBtnClicked()));
    connect(ui->btnCtan,SIGNAL(clicked()),this,SLOT(onBtnClicked()));


}
