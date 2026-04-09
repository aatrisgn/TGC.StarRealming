terraform {
  required_version = ">= 1.5.0"

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "4.68.0"
    }
  }
}

provider "azurerm" {
  features {}
  subscription_id = var.subscription_id
}

resource "azurerm_resource_group" "b2c" {
  name     = local.resource_group_name
  location = var.location
}

resource "azurerm_aadb2c_directory" "this" {
  domain_name             = local.b2c_domain_name
  display_name            = local.b2c_display_name
  resource_group_name     = azurerm_resource_group.b2c.name
  data_residency_location = "Europe"
  country_code            = var.b2c_country_code
  sku_name                = var.b2c_sku
}
