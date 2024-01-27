export interface User {
    id: number;
    firstName: string;
    lastName: string;
    country: string;
    province: string;
    city: string;
    zipCode: string;
    birthdate: string;
    phoneNumber: string;
    email: string;
    username: string;
    passwordHash: string;
    linkedInProfileUrl: string;
    isDeleted: boolean;
    lastModification: string;
}