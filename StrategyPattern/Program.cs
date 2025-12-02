using StrategyPattern;

PaymentService paymentService = new PaymentService();

paymentService.SetPaymentMethod(new CreditCardPayment());

paymentService.Pay();
