import React from "react";

export default function Ticket() {
  return (
    <>
      <section>
        <div className="min-h-screen flex items-center justify-center bg-gray-100">
          <div className="bg-white p-8 rounded-sm shadow-md w-full md:w-1/2 lg:w-1/3">
            <h1 className="text-2xl font-semibold mb-6">
              Create a Support Ticket
            </h1>
            <form>
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="ticketName">
                  Ticket Name
                </label>
                <input
                  className="w-full px-3 py-2 border rounded-lg focus:outline-none focus:ring focus:border-blue-300"
                  type="text"
                  id="ticketName"
                  name="ticketName"
                  placeholder="Enter ticket name"
                />
              </div>

              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="issueDetails">
                  Issue Details
                </label>
                <textarea
                  className="w-full px-3 py-2 border rounded-lg focus:outline-none focus:ring focus:border-blue-300"
                  id="issueDetails"
                  name="issueDetails"
                  rows="4"
                  placeholder="Enter issue details"></textarea>
              </div>

              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="priority">
                  Priority
                </label>
                <select
                  className="w-full px-3 py-2 border rounded-lg focus:outline-none focus:ring focus:border-blue-300"
                  id="priority"
                  name="priority">
                  <option value="low">Low</option>
                  <option value="medium">Medium</option>
                  <option value="high">High</option>
                </select>
              </div>

              <div className="flex justify-end">
                <button
                  className="px-4 py-2 bg-primary text-white rounded-sm hover:bg-secondary focus:outline-none focus:ring focus:border-blue-300"
                  type="submit">
                  Submit
                </button>
              </div>
            </form>
          </div>
        </div>
      </section>

      <section className="container p-3 shadow-lg bg-[#f1f1f1]">
        <div className="py-10 flex items-center justify-around ">
          <h3 className=" text-center font-serif font-semibold text-2xl  ">
            Email Box
          </h3>
          <div className="container mx-auto my-8">
            <table className="min-w-full bg-white border border-gray-300">
              <thead>
                <tr>
                  <th className="py-2 px-4 border-b">From</th>
                  <th className="py-2 px-4 border-b">Subject</th>
                  <th className="py-2 px-4 border-b">Message</th>
                </tr>
              </thead>
              <tbody>
                <tr className="hover:bg-gray-100">
                  <td className="py-2 px-4 border-b">Test 01</td>
                  <td className="py-2 px-4 border-b">Subject 01</td>
                  <td className="py-2 px-4 border-b">This is a message.</td>
                </tr>
                {/* Add more rows as needed */}
              </tbody>
            </table>
          </div>
        </div>
      </section>
    </>
  );
}
