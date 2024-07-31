import type { Metadata } from "next";
import { Inter } from "next/font/google";
import "./globals.css";
import PageNotFound from "./page-not-found";
import Toolbar from "./toolbar";

const inter = Inter({ subsets: ["latin"] });

export const metadata: Metadata = {
  title: "Apotheek App",
  description: "Apotheek App group project with react for practise",
};

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body className={inter.className}>
        <Toolbar></Toolbar>
          {children}
      </body>
    </html>
  );
}





