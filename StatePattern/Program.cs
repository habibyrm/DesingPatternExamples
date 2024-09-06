using StatePattern;

ATMMachine atmMachine = new ATMMachine();

// Card is inserted
atmMachine.InsertCard();

// PIN is entered
atmMachine.EnterPin(1234);

// Cash is withdrawn
atmMachine.WithdrawCash(500);

// Card is ejected
atmMachine.EjectCard();