﻿namespace EventBus.Messages.Events;

public class BasketCheckoutEvent : IntegrationBaseEvent
{
    public string UserName { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;

    public string BankName { get; set; } = string.Empty;
    public string RefCode { get; set; } = string.Empty;
    public int PaymentMethod { get; set; }
}