import { useState } from "react";
import "bootstrap/dist/css/bootstrap.css";
import "./App.css";

const poczatkoweZdjecia = [
  { id: 1, alt: "Czerwony mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
  { id: 2, alt: "Fioletowy bukiet", filename: "obraz2.jpg", category: 1, downloads: 43 },
  { id: 3, alt: "Dalmatyńczyk", filename: "obraz3.jpg", category: 2, downloads: 2 },
  { id: 4, alt: "Dwie świnki morskie", filename: "obraz4.jpg", category: 2, downloads: 53 },
  { id: 5, alt: "Szczeniak na chodniku", filename: "obraz5.jpg", category: 2, downloads: 43 },
  { id: 6, alt: "Czarne Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
  { id: 7, alt: "Śpiące koty", filename: "obraz7.jpg", category: 2, downloads: 0 },
  { id: 8, alt: "Kolorowe róże", filename: "obraz8.jpg", category: 1, downloads: 33 },
  { id: 9, alt: "Świnka morska", filename: "obraz9.jpg", category: 2, downloads: 0 },
  { id: 10, alt: "Pies z niebieską piłką", filename: "obraz10.jpg", category: 2, downloads: 0 },
  { id: 11, alt: "Leżący szczeniak", filename: "obraz11.jpg", category: 2, downloads: 0 },
  { id: 12, alt: "Niebieski Volkswagen", filename: "obraz12.jpg", category: 3, downloads: 321 },
];

const kategorie = [
  { id: 1, nazwa: "Kwiaty" },
  { id: 2, nazwa: "Zwierzęta" },
  { id: 3, nazwa: "Samochody" },
];

export default function App() {
  const [zdjecia, ustawZdjecia] = useState(poczatkoweZdjecia);
  const [aktywneKategorie, ustawAktywneKategorie] = useState({
    1: true,
    2: true,
    3: true,
  });

  function zmienKategorie(id) {
    ustawAktywneKategorie((poprzednie) => ({
      ...poprzednie,
      [id]: !poprzednie[id],
    }));
  }

  function pobierzZdjecie(id) {
    ustawZdjecia((poprzednie) =>
      poprzednie.map((zdjecie) =>
        zdjecie.id === id
          ? { ...zdjecie, downloads: zdjecie.downloads + 1 }
          : zdjecie
      )
    );
  }

  return (
    <main className="aplikacja">
      <h1>Kategorie zdjęć</h1>

      <div className="kategorie">
        {kategorie.map((kategoria) => (
          <div
            className="form-check form-switch form-check-inline"
            key={kategoria.id}
          >
            <input
              className="form-check-input"
              type="checkbox"
              role="switch"
              id={`kategoria-${kategoria.id}`}
              checked={aktywneKategorie[kategoria.id]}
              onChange={() => zmienKategorie(kategoria.id)}
            />
            <label
              className="form-check-label"
              htmlFor={`kategoria-${kategoria.id}`}
            >
              {kategoria.nazwa}
            </label>
          </div>
        ))}
      </div>

      <div className="galeria">
        {zdjecia
          .filter((zdjecie) => aktywneKategorie[zdjecie.category])
          .map((zdjecie) => (
            <article className="zdjecie" key={zdjecie.id}>
              <img
                src={`${import.meta.env.BASE_URL}assets/${zdjecie.filename}`}
                alt={zdjecie.alt}
              />
              <h4>Pobrań: {zdjecie.downloads}</h4>
              <button
                className="btn btn-success"
                type="button"
                onClick={() => pobierzZdjecie(zdjecie.id)}
              >
                Pobierz
              </button>
            </article>
          ))}
      </div>
    </main>
  );
}