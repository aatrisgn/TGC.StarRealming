variable "location" {
  description = "The Azure region for the resource group."
  type        = string
  default     = "westeurope"
}

variable "region_shortcode" {
  description = "Short code for the Azure region used in resource naming."
  type        = string
  default     = "weu"
}

variable "b2c_country_code" {
  description = "Two-letter ISO country code for the B2C tenant (e.g. DK, US)."
  type        = string
  default     = "DK"
}

variable "b2c_sku" {
  description = "SKU for the Azure AD B2C directory (PremiumP1 or PremiumP2)."
  type        = string
  default     = "PremiumP1"

  validation {
    condition     = contains(["PremiumP1", "PremiumP2"], var.b2c_sku)
    error_message = "b2c_sku must be PremiumP1 or PremiumP2."
  }
}

variable "resource_group_name" {
  description = "Azure resource group to deploy resources into"
  type        = string
}

variable "environment" {
  description = "environment type"
  type        = string

  validation {
    condition     = contains(["dev", "prod"], var.environment)
    error_message = "The environment variable must be either 'DEV' or 'PROD'."
  }
}

