import { useState } from "react";
import "bootstrap/dist/css/bootstrap.css";
import "./App.css";

export default function App() {
  const [tytul, ustawTytul] = useState("");
  const [rodzaj, ustawRodzaj] = useState("");

  function dodajFilm(zdarzenie) {
    zdarzenie.preventDefault();
    console.log(`tytul: ${tytul}; rodzaj: ${rodzaj}`);
  }

  return (
    <form onSubmit={dodajFilm}>
      <div className="mb-3">
        <label htmlFor="tytulFilmu" className="form-label">
          Tytuł filmu
        </label>
        <input
          type="text"
          id="tytulFilmu"
          name="tytul"
          className="form-control"
          value={tytul}
          onChange={(zdarzenie) => ustawTytul(zdarzenie.target.value)}
        />
      </div>

      <div className="mb-3">
        <label htmlFor="rodzajFilmu" className="form-label">
          Rodzaj
        </label>
        <select
          id="rodzajFilmu"
          name="rodzaj"
          className="form-control"
          value={rodzaj}
          onChange={(zdarzenie) => ustawRodzaj(zdarzenie.target.value)}
        >
          <option value=""></option>
          <option value="1">Komedia</option>
          <option value="2">Obyczajowy</option>
          <option value="3">Sensacyjny</option>
          <option value="4">Horror</option>
        </select>
      </div>

      <button type="submit" className="btn btn-primary">
        Dodaj
      </button>
    </form>
  );
}