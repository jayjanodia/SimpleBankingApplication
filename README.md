- Created a simple banking application that has a user with a checking and savings account. There is a button the user can click to open up a transaction/ATM window that allows them to withdraw a specific amount of money.
- If the user inputs a value less than the amount in the checking account, money gets debited from the checking account. However, if the user does not have enough money in the checking account and Overdraft is not disabled, the system will check if the remaining amount is present in the savings account and extract the remaining money from there.
- If the user still does not have enough money in both savings and checking accounts combined, they get a message for the same and no money is withdrawn.
- If the user selects "Prevent overdraft" and input an amount for debiting greater than the amount present in the checking account, money won't be transacted and the user will get a message for the same.