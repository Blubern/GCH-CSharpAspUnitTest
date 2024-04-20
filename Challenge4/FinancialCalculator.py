def calculate_investment(initial_investment, monthly_contribution, annual_interest_rate, investment_duration):
    # Convert annual interest rate to monthly rate
    monthly_interest_rate = annual_interest_rate / 12 / 100

    # Initialize variables
    total_investment = initial_investment
    months = investment_duration * 12

    # Loop through each month and calculate investment growth
    for month in range(months):
        total_investment *= (1 + monthly_interest_rate)  # Apply monthly interest
        total_investment += monthly_contribution  # Add monthly contribution

    return total_investment


def main():
    # Get user inputs
    initial_investment = float(input("Enter initial investment amount: $"))
    monthly_contribution = float(input("Enter monthly contribution amount: $"))
    annual_interest_rate = float(input("Enter annual interest rate (in percentage): "))
    investment_duration = int(input("Enter investment duration (in years): "))

    # Calculate investment return
    final_amount = calculate_investment(initial_investment, monthly_contribution, annual_interest_rate,
                                        investment_duration)

    # Calculate total invested capital
    total_invested = initial_investment + (monthly_contribution * investment_duration * 12)

    # Calculate the amount with interest rate
    amount_with_interest = final_amount

    # Calculate the difference amount of interest rate
    difference_amount = amount_with_interest - total_invested

    # Print the result
    print("\nTotal invested capital: ${:,.2f}".format(total_invested))
    print("Amount with interest rate: ${:,.2f}".format(amount_with_interest))
    print("Total Interest Earned: ${:,.2f}".format(difference_amount))


if __name__ == "__main__":
    main()
