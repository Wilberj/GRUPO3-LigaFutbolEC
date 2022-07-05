export default function CreateTableReport(Dataset = [], Table, Header = []) {
    const thead = Table.querySelector("thead");
    const tbody = Table.querySelector("tbody");
    thead.innerHTML = "";
    tbody.innerHTML = "";
    Dataset.forEach((Item, Index) => {
        const row = document.createElement("tr");
        for (var prop in Item) {
            if (Header.find(x => x == prop)) {
                if (Index == 0) {
                    const th = document.createElement("th");
                    th.innerText = prop;
                    thead.append(th);
                }
                const td = document.createElement("td");
                td.innerText = Item[prop];
                row.append(td)
            }
        }
        tbody.append(row);
    });
}